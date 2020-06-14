<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.Master" AutoEventWireup="true" CodeBehind="LoginMaster.aspx.cs" Inherits="LoginCalculator.LoginMaster1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cph_Header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cph_Scripts" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cph_Contenido" runat="server">
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <span class="login100-form-title p-b-43">
						Login to continue
					</span>								
					<div class="wrap-input100 validate-input" data-validate = "Valid email is required: ex@abc.xyz">						
                        <asp:TextBox ID="txt_email" runat="server" class="input100" type="text" name="email"/>
						<span class="focus-input100"></span>
						<span class="label-input100">Email</span>
					</div>										
					<div class="wrap-input100 validate-input" data-validate="Password is required">
                        <asp:TextBox ID="txt_Contra" runat="server" class="input100" type="password" name="pass"/>						
						<span class="focus-input100"></span>
						<span class="label-input100">Password</span>
					</div>
					<div class="flex-sb-m w-full p-t-3 p-b-32">
						<div class="contact100-form-checkbox">
							<input class="input-checkbox100" id="ckb1" type="checkbox" name="remember-me">
							<label class="label-checkbox100" for="ckb1">
								Remember me
							</label>
						</div>
						<div>
							<a href="#" class="txt1">
								Forgot Password?
							</a>
						</div>                          
					</div>
                    <div class="Datos">
                            <br />
                            <asp:Label ID="lbn_Mensaje" Text="" runat="server" class="Mensaje"/>
                            <asp:Label ID="lbn_Error" Text="" runat="server" class="Error"/>
                    </div> 
					<div class="container-login100-form-btn">					
                            <asp:Button ID="btn_Ingresar" Text="Login" runat="server" class="login100-form-btn" OnClick="btn_Ingresar_Click" />							
					</div>
					
					<div class="text-center p-t-46 p-b-20">
						<span class="txt2">
							or sign up using
						</span>
					</div>

					<div class="login100-form-social flex-c-m">
						<a href="#" class="login100-form-social-item flex-c-m bg1 m-r-5">
							<i class="fa fa-facebook-f" aria-hidden="true"></i>
						</a>

						<a href="#" class="login100-form-social-item flex-c-m bg2 m-r-5">
							<i class="fa fa-twitter" aria-hidden="true"></i>
						</a>
					</div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
