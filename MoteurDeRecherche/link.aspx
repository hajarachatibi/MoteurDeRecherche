<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="link.aspx.cs" Inherits="MoteurDeRecherche.link" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Liste des liens</title>
    <style type="text/css">
        .auto-style10 {
            width: 100%;
            height: 34px;
        }
        .auto-style11 {
            width: 5px;
            height: 30px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnback" runat="server" BackColor="#009999" Height="35px" Text="Back" Font-Size="20px" Width="130px" OnClick="btnback_Click" />
        </div><br/>
    <table class="auto-style10">
        <tr>
            <td class="auto-style11">
                <asp:Label ID="lblerror" runat="server" ForeColor="#CC0000" Height="40px" Font-Size="25px" Visible="False" Width="200px">No results !</asp:Label><br />
                <asp:Label ID="lblresult" runat="server" ForeColor="#00CC99" Height="40px" Text="Results:" Font-Size="25px" Visible="False" Width="200px"></asp:Label><br /><br />
            </td>
        </tr>
        </table>
        <div style="text-align:center; font-size: 25px; background-color:antiquewhite">
    <asp:Repeater ID="repLinks" runat="server" OnItemCommand="repLinks_ItemCommand">
        <ItemTemplate>
            <asp:LinkButton ID="linkbtn" CommandName="Click" runat="server" CommandArgument='<%# Eval("Text") %>'><%# Eval("Text") %></asp:LinkButton> <br /><br />
        </ItemTemplate>
    </asp:Repeater>
            </div>
    </form>
    </body>
</html>

