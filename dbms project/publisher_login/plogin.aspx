<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="plogin.aspx.cs" Inherits="dbms_project.publisher_login.plogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VAPOR</title>
    <link rel="stylesheet" type="text/css" href="../Stylesheet/stylesheet1.css" />
    <link rel="stylesheet" type="text/css" href="../Stylesheet/plogin.css" />
    <link href="https://fonts.googleapis.com/css?family=Josefin+Sans|Montserrat&display=swap" rel="stylesheet"/>

</head>
<body>
<form id="form1" runat="server">

    <!-- header -->
    <div class="topnav">
         <h1 class="logo">vapor</h1>
    </div>

        
            <div class="main1">       
                
                <h3 class="heading">CREATOR</h3>

                <asp:TextBox class="textbox t1" ID="TextBox1" runat="server" placeholder="Publisher Name"></asp:TextBox>  
                <asp:TextBox class="textbox t2" ID="TextBox2" runat="server" type="password" placeholder="Password"></asp:TextBox>
                
                <p class="tinytext"><input type="checkbox" onclick="myFunction()"/>Show Password</p>
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
                
                <asp:Button  class="button" ID="Button1" runat="server" OnClick="Button1_Click" Text="LOGIN"/>
                
                <asp:Label class="tinytext" ID="Label1" runat="server"></asp:Label>
            
        </div>

</form>
</body>
</html>