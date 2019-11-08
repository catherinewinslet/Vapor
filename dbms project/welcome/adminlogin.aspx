<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="dbms_project.welcome.adminlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VAPOR</title>
    <link rel="stylesheet" type="text/css" href="../Stylesheet/stylesheet1.css" />
    <link href="https://fonts.googleapis.com/css?family=Josefin+Sans|Montserrat&display=swap" rel="stylesheet"/>

</head>
<body>
<form id="form2" runat="server">

    <!-- header -->
    <div class="topnav">
         <h1 class="logo">vapor</h1>
    </div>

    <div class="main1">
            
        <h1 class="heading">admin</h1>
        <asp:TextBox class="textbox" ID="TextBox1" runat="server" placeholder="Admin Id" ></asp:TextBox>
        <asp:TextBox class="textbox" type="password" ID="TextBox2" runat="server" placeholder="Password" ></asp:TextBox>
        
        <asp:Button  class="button" ID="Button1" runat="server" OnClick="Button1_Click" Text="LOGIN" />
        <asp:Label class="tinytext" ID="Label1" runat="server"></asp:Label>

    </div>

</form>
</body>
</html>
