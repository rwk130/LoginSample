<%@ Page Title="" Language="C#" MasterPageFile="~/ObeyYour.master" AutoEventWireup="true" CodeBehind="congrats.aspx.cs" Inherits="LoginSample.loggedin.congrats" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Congradulations!!</h1>
    Dear <asp:Label ID="lblName" runat="server" />,<br /><br />
    You have successfully logged in! That's enough for now, so go home to <asp:Label ID="lblAddress" runat="server" /> and go to bed. You've earned it.
</asp:Content>
