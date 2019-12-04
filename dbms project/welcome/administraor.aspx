<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="administraor.aspx.cs" Inherits="dbms_project.welcome.administer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VAPOR</title>
    <link rel="stylesheet" type="text/css" href="../Stylesheet/stylesheet1.css" />
    <link rel="stylesheet" type="text/css" href="../Stylesheet/administraor.css" />
    <link href="https://fonts.googleapis.com/css?family=Josefin+Sans|Montserrat&display=swap" rel="stylesheet"/>
    <style>
        table {
            text-align: center;
            font:large;
            
            font-size:25px;
            text-transform:uppercase;
            color:white;
        }
        td{
            padding:15px;
            
        }
        th{
            padding:15px;
            color:deeppink;
        }
        tr:hover {background-color:white;}
    </style>
</head>
<body>
<form id="form1" runat="server">

        <!-- header -->
    <div class="topnav">
         <h1 class="logo">vapor</h1>
    </div>

                
                <!-- buttons -->
                <asp:Button class="administraorbutton" ID="Button1" runat="server" OnClick="Button1_Click" Text="Games" />
                <asp:Button class="administraorbutton" ID="Button2" runat="server" OnClick="Button2_Click" Text="Publisher" />
                <asp:Button class="administraorbutton" ID="Button3" runat="server" OnClick="Button3_Click" Text="Payment" />
                <asp:Button class="administraorbutton" ID="Button4" runat="server" OnClick="Button4_Click" Text="User" />

            
                <!-- table -->
                <div class="administraor">


                    <div class="overflow">
                <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="1310px">
                   
                </asp:GridView></div>

                </div>


</form>
</body>
</html>
