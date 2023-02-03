<%@ Page Title="" Language="C#" MasterPageFile="~/rootindex.Master" AutoEventWireup="true" CodeBehind="adduser.aspx.cs" Inherits="WebApplication1.adduser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <p>
        添加教师信息
    </p>
</div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="姓名"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="账户"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="密码"></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="年龄"></asp:Label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label5" runat="server" Text="部门"></asp:Label><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="职位"></asp:Label><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label7" runat="server" Text="工号"></asp:Label><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
     
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" />
    </div>

</asp:Content>
