<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TriangleLayout._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
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
    </div>
    <div id="Results" runat="server"></div>
</asp:Content>
