<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="dbms_project.login.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VAPOR</title>
    <link rel="stylesheet" type="text/css" href="../Stylesheet/stylesheet1.css" />
        <link rel="stylesheet" type="text/css" href="../Stylesheet/webform2.css" />
    <link href="https://fonts.googleapis.com/css?family=Josefin+Sans|Montserrat&display=swap" rel="stylesheet"/>
</head>
<body>
<form id="form2" runat="server">


    <!-- header -->
    <div class="topnav">
         <h1 class="logo">vapor</h1>
    </div>


            <div class="main1">
                
                <h1 class="heading" style="padding-left:65px">User</h1>


                <asp:TextBox class="textbox t1" ID="TextBox1" runat="server"  placeholder="username"></asp:TextBox> 
                <asp:TextBox class="textbox t2" ID="TextBox2" runat="server" type="password" placeholder="password" ></asp:TextBox>
                
                <!-- show password -->
                <p class="tinytext" style="padding-left: 56px;padding-top: 20px;"><input type="checkbox" onclick="myFunction()"/>Show Password</p>
                <script>
                function myFunction() {
                    var x = document.getElementById("TextBox2");
                    if (x.type === "password") {
                        x.type = "text";
                    } else {
                        x.type = "password";
                    }
                }
                </script>


                <asp:Button class="button" ID="Button1" runat="server" Text="LOGIN" OnClick="Button1_Click" />
                <asp:Label class="tinytext" ID="Label1" runat="server" style="padding-top: 0px; left: -55px;top: 225px;"></asp:Label>
            </div>

</form>
</body>
</html>
