<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pedit.aspx.cs" Inherits="dbms_project.publisher_login.pedit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VAPOR</title>
    <link rel="stylesheet" type="text/css" href="../Stylesheet/stylesheet1.css" />
    <link rel="stylesheet" type="text/css" href="../Stylesheet/pedit.css" />
    <link href="https://fonts.googleapis.com/css?family=Josefin+Sans|Montserrat&display=swap" rel="stylesheet"/>

</head>
<body>
<form id="form2" runat="server">

       <div class="topnav">
       <a href="pdashbord.aspx" class="logo" title="VAPOR"><svg width="41" height="82" viewBox="0 0 41 82" fill="none" xmlns="http://www.w3.org/2000/svg">
       <path d="M28.0218 26.3004C32.0899 21.8434 41.7073 9.5253 33.2037 0.137695C33.8987 6.0563 27.4994 14.8487 23.0274 19.3029C13.2333 29.0579 -0.219886 40.7644 0.225115 50.5196C0.437941 55.1852 2.36668 60.1974 6.33871 63.4164C6.00979 56.206 6.78291 50.2205 13.8541 41.8225C18.6923 36.0765 24.7835 29.8483 28.0218 26.3004Z" fill="#20DBE7"/>
       <path d="M32.1544 44.0568C36.2317 39.6082 45.8744 27.3099 37.3902 17.9048C38.073 23.8248 31.6556 32.604 27.1744 37.049C17.3602 46.7838 3.88304 58.4626 4.30796 68.2187C4.51118 72.8847 6.4296 77.9009 10.395 81.1281C10.0809 73.917 10.8663 67.9331 17.9548 59.5496C22.8048 53.8136 28.9088 47.598 32.1544 44.0568Z" fill="#20DBE7"/>
       <path d="M13.1336 67.9507C12.0853 69.9092 8.98525 74.7848 10.5889 81.8715C11.7268 77.9122 12.7751 75.9536 14.8268 73.0368C16.1947 71.0922 22.8994 64.3705 27.9615 58.5789C31.2526 54.8137 33.0685 51.787 33.2926 46.7851C30.2374 50.6602 25.94 54.764 23.2131 57.3679C21.2061 59.2844 14.1819 65.9921 13.1336 67.9507Z" fill="#20DBE7"/>
       </svg></a>
       </div>
    <!-- line -->
    <div class="hline"></div>
                <div>

                <!--image right-->
                <div class="right" >
                <asp:GridView  ID="GridView1" runat="server" AutoGenerateColumns="false" >
                 <Columns>
                    <asp:TemplateField >
                          <ItemTemplate>
                            <asp:Image ID="image1" runat="server" Width="500px" Height="500px" ImageUrl='<%#"data:Image/png;base64,"+Convert.ToBase64String ((byte[])Eval("img")) %>'/>
                          </ItemTemplate>
                    </asp:TemplateField>
                  </Columns>
                </asp:GridView>
                </div>

                <!--details left -->
                <div class="left" >

                <!-- line -->
                <div class="vline"></div>

                <!-- name -->
                <p class="detail l1"><asp:Label ID="Label3" runat="server"></asp:Label>:
                <asp:Label style="color:white" ID="Label10" runat="server"></asp:Label></p>
                <asp:Button class="button b1" ID="Button1" runat="server" OnClick="Button1_Click" Text="Edit Name" /><br />
                <asp:TextBox class="textbox l1" ID="TextBox1" runat="server" placeholder="Game Name"></asp:TextBox>               
                <asp:Button class="button" ID="Button4" runat="server" OnClick="Button4_Click" Text="save" /><br />
                
                <!-- size -->
                <p class="detail l2"><asp:Label ID="Label4" runat="server"></asp:Label>:
                <asp:Label style="color:white" ID="Label11" runat="server"></asp:Label></p>
                <asp:Button class="button b2" ID="Button2" runat="server" OnClick="Button2_Click" Text="Edit Size " /><br />
                <asp:TextBox class="textbox l2" ID="TextBox2" runat="server" placeholder="Game Size"></asp:TextBox>                
                <asp:Button class="button" ID="Button5" runat="server" OnClick="Button5_Click" Text="save" /><br />
                
                <!-- price -->
                <p class="detail l3"><asp:Label ID="Label5" runat="server"></asp:Label>:
                <asp:Label style="color:white" ID="Label12" runat="server"></asp:Label></p>
                <asp:Button class="button b3" ID="Button3" runat="server" OnClick="Button3_Click" Text="Edit Price" />   <br />        
                <asp:TextBox class="textbox l3" ID="TextBox3" runat="server" placeholder="Game Price" ></asp:TextBox>                
                <asp:Button class="button" ID="Button6" runat="server" OnClick="Button6_Click" Text="save" /><br />
                

                <asp:Label ID="Label13" runat="server"></asp:Label>
                <asp:Label ID="Label14" runat="server"></asp:Label>
                <asp:Label ID="Label15" runat="server"></asp:Label>  
                
                <!-- invalid -->
                <asp:Label class="tinytext" ID="Label16" runat="server"></asp:Label>

                <!-- done -->
                <br /><asp:Button class="button" ID="Button7" runat="server" OnClick="Button7_Click" Text="done" />

            </div>

    </div>
    

</form>
</body>
</html>
