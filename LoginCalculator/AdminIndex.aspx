<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.Master" AutoEventWireup="true" CodeBehind="AdminIndex.aspx.cs" Inherits="LoginCalculator.AdminIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_Scripts" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_Contenido" runat="server">
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
             <asp:LinkButton ID="Selector" runat="server" OnClick="nlkSeleccionar_Click"><i class="fa fa-power-off"></i> Logout</asp:LinkButton>            
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
