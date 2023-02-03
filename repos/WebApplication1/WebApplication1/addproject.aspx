<%@ Page Title="" Language="C#" MasterPageFile="~/teacherindex.Master" AutoEventWireup="true" CodeBehind="addproject.aspx.cs" Inherits="WebApplication1.addproject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>科研项目申报</p>
        <div>

            <asp:Label ID="Label1" runat="server" Text="项目名称:"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="项目描述:"></asp:Label>
    </div>
     <div>

   <asp:TextBox ID="TextBox3" runat="server" Height="246px" Width="303px"></asp:TextBox>

        </div>
    <asp:Button ID="Button1" runat="server" Text="申报" OnClick="Button1_Click" />
    <div>

    </div>

</asp:Content>
