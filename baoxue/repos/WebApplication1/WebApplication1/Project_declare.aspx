<%@ Page Title="" Language="C#" MasterPageFile="~/rootindex.Master" AutoEventWireup="true" CodeBehind="Project_declare.aspx.cs" Inherits="WebApplication1.Project_declare" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div>


        <asp:Label ID="Label1" runat="server" Text="文章"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="搜索" OnClick="Button1_Click" />
    </div>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView2_RowDeleting" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating">
    <Columns>

        <asp:BoundField DataField="name" HeaderText="教师" />
        <asp:BoundField DataField="Age" HeaderText="年龄" />
        <asp:BoundField DataField="Department" HeaderText="部门" />
        <asp:BoundField DataField="ProjectName" HeaderText="科研项目名字" />
        <asp:BoundField HeaderText="科研项目" DataField="projectdec" />
        <asp:BoundField DataField="State" HeaderText="状态" />
        <asp:BoundField DataField="Project_Id" HeaderText="文章id" />
        <asp:BoundField DataField="user_id" HeaderText="用户id" />
        <asp:CommandField EditText="申报通过" ShowEditButton="True" />
        <asp:CommandField DeleteText="不通过" ShowDeleteButton="True" />
    </Columns>
</asp:GridView>
</asp:Content>
