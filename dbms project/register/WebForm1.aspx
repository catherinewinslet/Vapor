<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="dbms_project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VAPOR</title>
    <link rel="stylesheet" type="text/css" href="../Stylesheet/stylesheet1.css" />
    <link href="https://fonts.googleapis.com/css?family=Josefin+Sans|Montserrat&display=swap" rel="stylesheet"/>
        <link rel="stylesheet" type="text/css" href="../Stylesheet/webform1.css" />
</head>
<body>
        <form id="form1" runat="server" method="post">
        
            
        <!-- header -->
        <div class="topnav">
            <h1 class="logo" >vapor</h1>
        </div> 

        <!-- main -->
        <div class="main1">       
                <!-- username -->
                <asp:TextBox class="textbox t1" ID="TextBox3" runat="server" placeholder="User Name" ></asp:TextBox>
                
                <!-- password -->
                <asp:TextBox class="textbox t2" ID="TextBox2" type="password" runat="server" placeholder="Password" ></asp:TextBox>
                
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

                <!-- age -->
                <asp:TextBox class="textbox t3" ID="TextBox4" runat="server" placeholder="Age" BackColor="#BFBEC2"></asp:TextBox>

                <asp:Button class="button" ID="Button1" runat="server" Text="REGISTER" Width="181px" OnClick="Button1_Click" />

                <asp:Label class="tinytext" ID="Label6" runat="server"></asp:Label>
        </div>


    </form>
</body>
</html>
