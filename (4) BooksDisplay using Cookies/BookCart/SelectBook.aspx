<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectBook.aspx.cs" Inherits="BookCart.SelectBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblselect" runat="server" Font-Size="X-Large" Text="Select a book : "></asp:Label>
&nbsp;&nbsp;
            <br />
            <asp:RadioButtonList ID="lstbooks" runat="server" Font-Size="X-Large">
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="btnadd" runat="server" Font-Size="X-Large" OnClick="btnadd_Click" Text="Add Book" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnview" runat="server" Font-Size="X-Large" PostBackUrl="~/ViewDetails.aspx" Text="View Details" />
            <br />
            <br />
            <asp:Label ID="lblmsg" runat="server" Font-Size="X-Large"></asp:Label>
        </div>
    </form>
</body>
</html>
