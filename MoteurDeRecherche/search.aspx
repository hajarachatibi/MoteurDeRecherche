<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="MoteurDeRecherche.search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page de recherche</title>
</head>
<body style="height: 100%; width: 100%; text-align: center;">
    <form id="form1" runat="server" style="text-align: center;margin-left:auto;margin-right:auto;">
            <br/><br/><br/><br/><br/><br/>
            <asp:Image ID="Image1" ImageUrl="~/icon.jpg" runat="server" Height="160px" /> <br/>
        <asp:TextBox ID="txtsearch" runat="server" BorderColor="#006699" ForeColor="#666666" Height="29px" Width="475px"></asp:TextBox>
        <asp:Button ID="btnsearch" runat="server" BackColor="White" BorderColor="#006699" CssClass="auto-style2" Height="35px" Text="Search" Width="130px" OnClick="btnsearch_Click" />
    </form>
</body>
</html>


