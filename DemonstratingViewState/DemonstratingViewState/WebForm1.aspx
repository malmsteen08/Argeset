<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DemonstratingViewState.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="myListBox" runat="server">
            <asp:ListItem>Item One</asp:ListItem>
            <asp:ListItem>Item Two</asp:ListItem>
            <asp:ListItem>Item Three</asp:ListItem>
            <asp:ListItem>Item Four</asp:ListItem>
        </asp:ListBox>
    </div>
    </form>
</body>
</html>
