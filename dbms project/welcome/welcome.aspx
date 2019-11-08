<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="dbms_project.welcome.welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VAPOR</title>
    <link rel="stylesheet" type="text/css" href="../Stylesheet/stylesheet1.css" />
    <link rel="stylesheet" type="text/css" href="../Stylesheet/welcome.css" />
    <link href="https://fonts.googleapis.com/css?family=Josefin+Sans|Montserrat&display=swap" rel="stylesheet"/>
</head>

<body>
    <form id="form1" runat="server">

    <!-- header -->
    <div class="topnav">
         <h1 class="logo">vapor</h1>
    </div>

    
    <div class="main">
        <!-- publisher login -->
            <div class="main1 left">
                <p class="heading" style="padding-left:60px">creator</p>
                <asp:Button class="button welcome login" ID="Button3" runat="server" Text="LOGIN" OnClick="Button3_Click"  />
                <asp:Button class="button welcome signup" ID="Button4" runat="server" Text="SIGN UP" OnClick="Button4_Click"/>
            </div>

        <!-- user login -->
            <div class="main1 right">
                <p class="heading">user</p>
                <asp:Button class="button welcome login" ID="Button5" runat="server" Text="LOGIN" OnClick="Button1_Click"  />
                <asp:Button class="button welcome signup" ID="Button6" runat="server" Text="SIGN UP" OnClick="Button2_Click"/>
            </div>
     </div>

    <!--- admin login --->
    <!--<asp:Button ID="Button7" runat="server" Text=" click here"  OnClick="Button7_Click" />-->
    <p class="tinytext">are you the admin?
        <u><a class="link" href="adminlogin.aspx"> click here</a></u>
    </p>


    </form>
</body>
</html>
