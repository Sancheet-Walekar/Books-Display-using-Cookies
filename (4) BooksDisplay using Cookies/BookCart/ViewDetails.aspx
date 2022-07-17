<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewDetails.aspx.cs" Inherits="BookCart.ViewDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            You have selected :
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Font-Size="Large" Height="210px" Width="453px"></asp:ListBox>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="Large" PostBackUrl="~/SelectBook.aspx">Select another book</asp:LinkButton>
        </div>
    </form>
</body>
</html>
