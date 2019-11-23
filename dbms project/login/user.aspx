﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="dbms_project.login.user" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VAPOR</title>
    <link rel="stylesheet" type="text/css" href="../Stylesheet/stylesheet1.css" />
    <link href="https://fonts.googleapis.com/css?family=Josefin+Sans|Montserrat&display=swap" rel="stylesheet"/>
    <link rel="stylesheet" type="text/css" href="../Stylesheet/user.css" />
    <style>
        #underline:hover
        {
            color:rgba(32, 219, 231, 0.7)
        }
    </style>
</head>
<body>
<form id="form1" runat="server">


       <div class="topnav">
         <p class="logo" title="VAPOR"><svg width="41" height="82" viewBox="0 0 41 82" fill="none" xmlns="http://www.w3.org/2000/svg">
         <path d="M28.0218 26.3004C32.0899 21.8434 41.7073 9.5253 33.2037 0.137695C33.8987 6.0563 27.4994 14.8487 23.0274 19.3029C13.2333 29.0579 -0.219886 40.7644 0.225115 50.5196C0.437941 55.1852 2.36668 60.1974 6.33871 63.4164C6.00979 56.206 6.78291 50.2205 13.8541 41.8225C18.6923 36.0765 24.7835 29.8483 28.0218 26.3004Z" fill="#20DBE7"/>
         <path d="M32.1544 44.0568C36.2317 39.6082 45.8744 27.3099 37.3902 17.9048C38.073 23.8248 31.6556 32.604 27.1744 37.049C17.3602 46.7838 3.88304 58.4626 4.30796 68.2187C4.51118 72.8847 6.4296 77.9009 10.395 81.1281C10.0809 73.917 10.8663 67.9331 17.9548 59.5496C22.8048 53.8136 28.9088 47.598 32.1544 44.0568Z" fill="#20DBE7"/>
         <path d="M13.1336 67.9507C12.0853 69.9092 8.98525 74.7848 10.5889 81.8715C11.7268 77.9122 12.7751 75.9536 14.8268 73.0368C16.1947 71.0922 22.8994 64.3705 27.9615 58.5789C31.2526 54.8137 33.0685 51.787 33.2926 46.7851C30.2374 50.6602 25.94 54.764 23.2131 57.3679C21.2061 59.2844 14.1819 65.9921 13.1336 67.9507Z" fill="#20DBE7"/>
         </svg>
         </p>
       </div>


            <div class="mainmedium" style="padding-top:50px; padding-bottom:50px">
                
                <p class="tinytext t1" style="font-size:22px">Welcome, <asp:Label CssClass="label" ID="Label2" runat="server" Text="Label"></asp:Label></p>
                
                <!-- search for new game -->
                <a class="tinytext t2" id="underline" href="../search/search.aspx" style="font-size:22px; border:double rgba(32, 219, 231, 0.7) ; padding-left:20px; padding-top:10px;padding-bottom:10px">search for a new game</a>
                
                <div class="overflow">
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" style="margin-left: 45px; margin-top: 17px" Width="1131px" AutoGenerateColumns="false" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="game_name" HeaderText="name"/>
                        
                <asp:TemplateField HeaderText="Image">
                      <ItemTemplate>
                        <asp:Image ID="image1" runat="server" Width="300px" Height="300px" ImageUrl='<%#"data:Image/png;base64,"+Convert.ToBase64String ((byte[])Eval("img")) %>'/>
                      </ItemTemplate>

                </asp:TemplateField>
                    </Columns>
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView></div>

                

            </div>


</form>
</body>
</html>
