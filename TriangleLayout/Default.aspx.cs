using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            string result = string.Empty;
            int x1 = -1, x2 = -1, x3 = -1, y1 = -1, y2 = -1, y3 = -1;
            List<int> xcords = new List<int>();
            List<int> ycords = new List<int>();
            int nonHypotenuse = 10;
            if (Int32.TryParse(TextBoxNonHypotenuseLength.Text, out nonHypotenuse) && nonHypotenuse <= 75 && nonHypotenuse >= 10)
            {
                int column = 12;
                Char row = 'F';
                if(!Char.TryParse(TextBoxMaxRow.Text, out row))
                {
                    result = "Invalid row, using default of 'F'<br/>";
                }
                if(!Int32.TryParse(TextBoxMaxColumn.Text, out column) && column % 2 == 0 && column >= 12 && column <= 22)
                {
                    result += "Invalid column, using default of 12<br/>";
                }

                if (Int32.TryParse(TextBoxV1x.Text, out x1) && Int32.TryParse(TextBoxV2x.Text, out x2) && Int32.TryParse(TextBoxV3x.Text, out x3)
                    && Int32.TryParse(TextBoxV1y.Text, out y1) && Int32.TryParse(TextBoxV2y.Text, out y2) && Int32.TryParse(TextBoxV3y.Text, out y3))
                {
                    xcords.Add(x1);
                    xcords.Add(x2);
                    xcords.Add(x3);
                    ycords.Add(y1);
                    ycords.Add(y2);
                    ycords.Add(y3);

                    if (((xcords.Max() - xcords.Min()) == 10) && ((ycords.Max() - ycords.Min()) == 10))
                    {
                        var triangle = FindTriangle(xcords, ycords, 10);

                        result = "Triangle Selected: " + triangle;
                        result += "<br/><br/>";
                        result += DrawTriangle(triangle, nonHypotenuse.ToString(), row, column);
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
            }
            else
            {
                result = "Please enter a px value between 10 and 50";
            }
            Results.InnerHtml = result;
        }

        public string FindTriangle(List<int> xcords, List<int> ycords, int nonHypotenuse)
        {
            xcords.Sort();
            ycords.Sort();

            var xMedianValue = xcords[1];
            var yMedianValue = ycords[1];
            var xMaxValue = xcords.Max();
            var yMaxValue = ycords.Max();

            string row = IntToLetters(yMaxValue / nonHypotenuse);
            string column = ((xMedianValue / nonHypotenuse) + (xMaxValue / nonHypotenuse)).ToString();

            return row + column;
        }

        public string DrawTriangle(string mainTriangle, string nonHypotenuse, Char row, int column)
        {
            StringBuilder html = new StringBuilder();
            bool isLeft = true;

            for (char c = 'A'; c <= row; c++)
            {
                for (int i = 1; i <= column; i++)
                {
                    bool highlight = ((c.ToString() + i.ToString()) == mainTriangle);
                    if (isLeft)
                    {
                        html.Append("<div style=\"width: " + nonHypotenuse + "px; padding-bottom: " + nonHypotenuse + "px;\" class=\"triangle-left" + (highlight ? " highlighted-left" : "") + "\"></div>");
                    }
                    else
                    {
                        html.Append("<div style=\"padding-left:" + nonHypotenuse + "px; padding-top: " + nonHypotenuse + "px; margin-left:-" + nonHypotenuse + "px;\" class=\"triangle-right" + (highlight ? " highlighted-right" : "") + "\"></div>");
                    }
                    isLeft = !isLeft;
                }
                html.Append("<div style=\"float:left;clear:both;\"></div>");
            }
            return html.ToString();
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