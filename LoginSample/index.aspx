<%@ Page Title="" Language="C#" MasterPageFile="~/ObeyYour.master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MovieList.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-1">Your name:<asp:CustomValidator ID="cvName" runat="server" Text="*" Display="Static" ErrorMessage="Invalid Name" CssClass="redText" /></div>
        <div class="col-1"><asp:TextBox ID="txtFirstName" runat="server" placeholder="First Name" /></div>
        <div class="col-1"><asp:TextBox ID="txtMiddleName" runat="server" placeholder="Middle Name" /></div>
        <div class="col-1"><asp:TextBox ID="txtLastName" runat="server" placeholder="Last Name" /></div>
    </div>
    <div class="row">
        <div class="col-1">Address:<asp:CustomValidator ID="cvAddress" runat="server" Text="*" ErrorMessage="Invalid Address" CssClass="redText" /></div>
        <div class="col-3"><asp:TextBox ID="txtAddress" runat="server" placeholder="Street Address" /></div>
    </div>
    <div class="row">
        <div class="col-1">E-mail:<asp:CustomValidator ID="cvEmail" runat="server" Text="*" ErrorMessage="Invalid E-mail" CssClass="redText" /></div>
        <div class="col-3"><asp:TextBox ID="txtEmail" runat="server" placeholder="E-mail Address" /></div>
    </div>
    <asp:Panel ID="pnlCreate" runat="server">
        <asp:ValidationSummary ID="vs1" runat="server" DisplayMode="BulletList" CssClass="redText" />
        <div class="row"><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></div>
    </asp:Panel>
    <asp:Panel ID="pnlPassword" runat="server" Visible="false">
        <div class="row">
            Your new password is: <h1><asp:Label ID="lblPassword" runat="server" /></h1>
            Click <a href="login.aspx">here</a> to use it.
        </div>
    </asp:Panel>
</asp:Content>
