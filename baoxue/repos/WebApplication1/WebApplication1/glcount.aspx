﻿<%@ Page Title="" Language="C#" MasterPageFile="~/rootindex.Master" AutoEventWireup="true" CodeBehind="glcount.aspx.cs" Inherits="WebApplication1.glcount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
        管理系科研申报情况
    </div>
  <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" >
    <Columns>

        <asp:BoundField DataField="name" HeaderText="教师" />
        <asp:BoundField DataField="Age" HeaderText="年龄" />
        <asp:BoundField DataField="Department" HeaderText="部门" />
        <asp:BoundField DataField="ProjectName" HeaderText="科研项目名字" />
        <asp:BoundField HeaderText="科研项目" DataField="projectdec" />
        <asp:BoundField DataField="State" HeaderText="状态" />
        <asp:BoundField DataField="Project_Id" HeaderText="文章id" />
        <asp:BoundField DataField="user_id" HeaderText="用户id" />
     
    </Columns>
</asp:GridView>
</asp:Content>
