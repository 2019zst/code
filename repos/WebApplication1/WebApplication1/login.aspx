<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="/css/login.css">

</head>

<body>
    <form id="form1" runat="server">
        <div class="head">
     <div class="login_img">
   <%--      <img src="/image/index.jpg" />--%>
            <div class="login">
                <div class="logintop">
            <p>高校社团管理系统</p>
                </div>
                <div>
                    <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" Height="23px" Width="171px"></asp:TextBox>
                </div>

                <div class="password">

                    <asp:Label ID="Label2" runat="server" Text="密 码"></asp:Label>
                   <asp:TextBox ID="TextBox2" runat="server" Height="21px" Width="170px " style="  margin-left: 12px;"></asp:TextBox>
                </div>

                <div>


                    <asp:Button ID="Button1" runat="server" Text="登录"  style="margin-left: 41px; margin-top:20px" OnClick="Button1_Click1" /> 
                    <asp:Button ID="Button2" runat="server" Text="忘记密码" style="margin-left: 97px;"  />


                </div>
                </div>
            </div>
        </div>         
   


    </form>
</body>
</html>
