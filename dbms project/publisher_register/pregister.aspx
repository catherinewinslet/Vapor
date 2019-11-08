<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pregister.aspx.cs" Inherits="dbms_project.publisher_register.pregister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VAPOR</title>
        <link rel="stylesheet" type="text/css" href="../Stylesheet/stylesheet1.css" />
        <link rel="stylesheet" type="text/css" href="../Stylesheet/pregister.css" />
        <link href="https://fonts.googleapis.com/css?family=Josefin+Sans|Montserrat&display=swap" rel="stylesheet"/>

</head>
<body>
<form id="form1" runat="server">

        <!-- header -->
        <div class="topnav">
            <h1 class="logo" >vapor</h1>
        </div>

        <!--main1-->
        <div class="main1">       
            
            <!-- publisher name -->
            <asp:TextBox CssClass="textbox t1" ID="TextBox1" runat="server" placeholder="Publisher Name" ></asp:TextBox>
            
            <!-- password -->
            <asp:TextBox CssClass="textbox t2" ID="TextBox4" runat="server" placeholder="Password" ></asp:TextBox>
            
            <!-- show password -->
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

            <!-- address -->
            <asp:TextBox CssClass="textbox t3" ID="TextBox2" runat="server" placeholder="country"></asp:TextBox>
            
            <!-- Contact Number  -->
            <asp:TextBox CssClass="textbox t4" ID="TextBox3" runat="server" placeholder="Contact Number"></asp:TextBox>
            
            <asp:Button CssClass="button" ID="Button1" runat="server" Text="REGISTER" OnClick="Button1_Click"/>
            
            <asp:Label CssClass="tinytext" ID="Label1" runat="server"></asp:Label>
        </div>

</form>
</body>
</html>
