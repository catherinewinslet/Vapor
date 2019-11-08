<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="img.aspx.cs" Inherits="dbms_project.trying.img" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="show" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Size" HeaderText="size"/>


                <asp:TemplateField HeaderText="image">
                      <ItemTemplate>
                        <asp:Image ID="image1" runat="server" Width="300px" Height="300px" ImageUrl='<%#"data:Image/png;base64,"+Convert.ToBase64String ((byte[])Eval("ImageData")) %>'/>
                      </ItemTemplate>

                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
