<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="administraor.aspx.cs" Inherits="dbms_project.welcome.administer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VAPOR</title>
    <link rel="stylesheet" type="text/css" href="../Stylesheet/stylesheet1.css" />
    <link href="https://fonts.googleapis.com/css?family=Josefin+Sans|Montserrat&display=swap" rel="stylesheet"/>

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

                    <!-- initial -->
                    <p class="administraortext">choose a table to view</p>


                <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="1310px">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>

                </div>


</form>
</body>
</html>
