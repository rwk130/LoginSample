<%@ Page Title="" Language="C#" MasterPageFile="~/ObeyYour.master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LoginSample.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-1">E-mail</div>
        <div class="col-3"><asp:TextBox ID="txtEmail" runat="server" /></div>
    </div>
    <div class="row">
        <div class="col-1">Password</div>
        <div class="col-3"><asp:TextBox ID="txtPass" runat="server" TextMode="Password" /></div>
    </div>
    <div class="row">
        <div class="col-4"><asp:Button ID="btnSubmit" runat="server" Text="login" OnClick="btnSubmit_Click" /></div>
    </div>
    <div class="row">
        <div class="col-4"><asp:Label ID="lblReturn" runat="server" /></div>
    </div>
</asp:Content>
