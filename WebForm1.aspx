<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username is
            <asp:TextBox ID="usernameReader" runat="server"></asp:TextBox>
&nbsp;<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
&nbsp;&nbsp;&nbsp;
        </div>
        Yout Name IS&nbsp;
        <asp:Label ID="usernamePrinter" runat="server"></asp:Label>
    </form>
</body>
</html>
