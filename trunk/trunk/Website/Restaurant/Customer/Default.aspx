<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Customer.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Customer.Default" %>

<%@ Register Src="~/Controls/Shared/TraCuuBanTrong.ascx" TagName="TraCuuBanTrong" TagPrefix="uc" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="MainContent">
    <uc:TraCuuBanTrong ID="ucTraCuuBanTrong" runat="server" />
</asp:Content>
