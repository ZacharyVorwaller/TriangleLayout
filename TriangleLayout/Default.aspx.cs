using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TriangleLayout
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSolve_Click(object sender, EventArgs e)
        {
            string result = String.Empty;
            int x1 = -1, x2 = -1, x3 = -1, y1 = -1, y2 = -1, y3 = -1;
            List<int> xcords = new List<int>();
            List<int> ycords = new List<int>();

            if (Int32.TryParse(TextBoxV1x.Text, out x1) && Int32.TryParse(TextBoxV2x.Text, out x2) && Int32.TryParse(TextBoxV3x.Text, out x3)
                && Int32.TryParse(TextBoxV1y.Text, out y1) && Int32.TryParse(TextBoxV2y.Text, out y2) && Int32.TryParse(TextBoxV3y.Text, out y3))
            {
                if (((xcords.Max() - xcords.Min()) == 10) && ((ycords.Max() - ycords.Min()) == 10))
                {
                    xcords.Add(x1);
                    xcords.Add(x2);
                    xcords.Add(x3);
                    ycords.Add(y1);
                    ycords.Add(y2);
                    ycords.Add(y3);


                    result = FindTriangle(xcords, ycords);
                }
                else
                {
                    result = "Please enter coordinates for just one triangle";
                }
            }
            else
            {
                result = "Please enter a vaild number for each coordinate";
            }
            Results.InnerHtml = result;
        }

        public string FindTriangle(List<int> xcords, List<int> ycords)
        {
            xcords.Sort();
            ycords.Sort();

            var xMedianValue = xcords[1];
            var yMedianValue = ycords[1];
            var xMaxValue = xcords.Max();
            var yMaxValue = ycords.Max();

            string row = IntToLetters(yMaxValue / 10);
            string column = ((xMedianValue / 10) + (xMaxValue / 10)).ToString();

            return row + column;
        }
        public static string IntToLetters(int value)
        {
            string result = string.Empty;
            while (--value >= 0)
            {
                result = (char)('A' + value % 26) + result;
                value /= 26;
            }
            return result;
        }
    }
}