<%@ Page Title="" Language="C#" MasterPageFile="~/rootindex.Master" AutoEventWireup="true" CodeBehind="teacherinfo.aspx.cs" Inherits="WebApplication1.WebForm3" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div> <asp:Label ID="Label1" runat="server" Text="姓名:"></asp:Label> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="搜索" OnClick="Button1_Click" /></div>


    <asp:GridView ID="GridView1" runat="server" Height="16px" Width="642px" AutoGenerateColumns="False" style="margin-bottom: 0px" DataKeyNames="User_id" OnRowDeleting="GridView1_RowDeleting"   BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnRowEditing="GridView1_RowEditing" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
        <Columns>
            <asp:BoundField DataField="User_id" HeaderText="用户Id" />
            <asp:BoundField ApplyFormatInEditMode="True" DataField="name" HeaderText="姓名" />
            <asp:BoundField DataField="Identity" HeaderText="身份" />
            <asp:BoundField DataField="Account" HeaderText="账户" />
            <asp:BoundField DataField="Password" HeaderText="密码" />
            <asp:BoundField DataField="Age" HeaderText="年龄" />
            <asp:BoundField DataField="Department" HeaderText="部门" />
            <asp:BoundField DataField="Title" HeaderText="职位" />
            <asp:BoundField DataField="number" HeaderText="工号" />
            <asp:CommandField ShowDeleteButton="True" />
            <asp:CommandField ShowEditButton="True" EditText="修改" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
</asp:GridView>
    
</asp:Content>
