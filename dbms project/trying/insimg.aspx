<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insimg.aspx.cs" Inherits="dbms_project.trying.insimg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            enter thegame name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="save" />
        </p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
