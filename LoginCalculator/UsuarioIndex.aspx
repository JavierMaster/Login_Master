<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMasterUsu.Master" AutoEventWireup="true" CodeBehind="UsuarioIndex.aspx.cs" Inherits="LoginCalculator.UsuarioIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_Scripts" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_Contenido" runat="server">
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="col-md-9 col-sm-12 col-xs-12">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                Puedes Realizar suma, resta, multiplicaion, division, radicacion y potencia.
                            </div>
                            <div class="panel-body">
                                <!--
                                <div id="morris-bar-chart"></div>
                                -->
                                <div class="Caja">                                        
                                        <asp:TextBox ID="txt_Pantalla" type="textfield" name="ans" value="" runat="server" class="Pantalla" readonly="true"/>
                                        <br>                                       
                                        <asp:Button ID="btn_Tecla_9" Text="9" runat="server" class="Teclas" OnClick="btn_Tecla_9_Click"/>
                                        <asp:Button ID="btn_Tecla_8" Text="8" runat="server" class="Teclas" OnClick="btn_Tecla_8_Click"/>
                                        <asp:Button ID="btn_Tecla_7" Text="7" runat="server" class="Teclas" OnClick="btn_Tecla_7_Click"/>
                                        <asp:Button ID="btn_Tecla_suma" Text="+" runat="server" class="Teclas" OnClick="btn_Tecla_suma_Click"/>
                                        <asp:Button ID="btn_Tecla_resta" Text="-" runat="server" class="Teclas" OnClick="btn_Tecla_resta_Click"/>                                        
                                        <br>
                                        <asp:Button ID="btn_Tecla_4" Text="4" runat="server" class="Teclas" OnClick="btn_Tecla_4_Click"/>
                                        <asp:Button ID="btn_Tecla_5" Text="5" runat="server" class="Teclas" OnClick="btn_Tecla_5_Click"/>
                                        <asp:Button ID="btn_Tecla_6" Text="6" runat="server" class="Teclas" OnClick="btn_Tecla_6_Click"/>
                                        <asp:Button ID="btn_Tecla_multi" Text="x" runat="server" class="Teclas" OnClick="btn_Tecla_multi_Click"/>
                                        <asp:Button ID="btn_Tecla_division" Text="/" runat="server" class="Teclas" OnClick="btn_Tecla_division_Click"/>
                                        <br>
                                        <asp:Button ID="btn_Tecla_1" Text="1" runat="server" class="Teclas" OnClick="btn_Tecla_1_Click"/>
                                        <asp:Button ID="btn_Tecla_2" Text="2" runat="server" class="Teclas" OnClick="btn_Tecla_2_Click"/>
                                        <asp:Button ID="btn_Tecla_3" Text="3" runat="server" class="Teclas" OnClick="btn_Tecla_3_Click"/>
                                        <asp:Button ID="btn_Tecla_potencia" Text="P" runat="server" class="Teclas" OnClick="btn_Tecla_potencia_Click"/>
                                        <asp:Button ID="btn_Tecla_raiz" Text="R" runat="server" class="Teclas" OnClick="btn_Tecla_raiz_Click"/>
                                        <br>
                                        <asp:Button ID="btn_Tecla_Borrar" Text="C" runat="server" class="Teclas" OnClick="btn_Tecla_Borrar_Click"/>
                                        <asp:Button ID="btn_Tecla_0" Text="0" runat="server" class="Teclas" OnClick="btn_Tecla_0_Click"/>
                                        <asp:Button ID="btn_Tecla_punto" Text="." runat="server" class="Teclas" OnClick="btn_Tecla_punto_Click"/>   
                                        <asp:Button ID="btn_Tecla_Igual" Text="=" runat="server" class="Teclas" OnClick="btn_Tecla_Igual_Click" /> 
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-12 col-xs-12">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                Historial
                            </div>
                            <div class="panel-body">
                                <!--
                                <div id="morris-donut-chart"></div>
                                -->
                            </div>
                        </div>
                    </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
