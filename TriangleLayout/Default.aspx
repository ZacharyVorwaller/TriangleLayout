<%@ Page Title="Triangle Layout Solver" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TriangleLayout._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp:Label ID="LabelRows" runat="server" Text="Max Row (A-Z)"></asp:Label>
        <asp:TextBox ID="TextBoxMaxRow" runat="server">F</asp:TextBox>
        <br />
        <asp:Label ID="LabelColums" runat="server" Text="Max Column (Even number between 12-22)"></asp:Label>
        <asp:TextBox ID="TextBoxMaxColumn" runat="server">12</asp:TextBox>
        <br />
        <asp:Label ID="LabelTriangle" runat="server" Text="Triangle Display px (10-75)"></asp:Label>
        <asp:TextBox ID="TextBoxNonHypotenuseLength" runat="server">10</asp:TextBox><br />
        <asp:Label ID="LabelTriangle2" runat="server" Text="This is used to enlarge the triangle display size but does not affect the calculations or coordinates value of 10px being used"></asp:Label>

        <br />
        <br />
        <asp:Label ID="LabelV1x" runat="server" Text="V1x:"></asp:Label>
        <asp:TextBox ID="TextBoxV1x" runat="server"></asp:TextBox>
        <asp:Label ID="LabelV1y" runat="server" Text="V1y:"></asp:Label>
        <asp:TextBox ID="TextBoxV1y" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelV2x" runat="server" Text="V2x:"></asp:Label>
        <asp:TextBox ID="TextBoxV2x" runat="server"></asp:TextBox>
        <asp:Label ID="LabelV2y" runat="server" Text="V2y:"></asp:Label>
        <asp:TextBox ID="TextBoxV2y" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelV3x" runat="server" Text="V3x:"></asp:Label>
        <asp:TextBox ID="TextBoxV3x" runat="server"></asp:TextBox>
        <asp:Label ID="LabelV3y" runat="server" Text="V3y:"></asp:Label>
        <asp:TextBox ID="TextBoxV3y" runat="server"></asp:TextBox>
    &nbsp;<asp:Button ID="ButtonSolve" runat="server" Text="Solve" OnClick="ButtonSolve_Click" />
        <br />
        <br />
    </div>
    <div id="Results" class="results" runat="server"></div>
</asp:Content>
