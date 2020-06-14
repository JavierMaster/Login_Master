using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using Capa_Negocio;

namespace LoginCalculator
{
    public partial class LoginMaster1 : System.Web.UI.Page
    {
        private CN_Usuario cn_usu = new CN_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            lbn_Error.Text = null;
            lbn_Mensaje.Text = null;           
        }

        protected void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_Contra.Text))
            {
                lbn_Error.Visible = true;
                lbn_Mensaje.Visible = false;
                lbn_Error.Text = "LLene los campos Necesarios";
            }
            else if (CN_Usuario.VerificarUsuario(txt_email.Text) == true && CN_Usuario.VerificarContra(txt_Contra.Text) == true && CN_Usuario.VerificarUsuContra(txt_email.Text, txt_Contra.Text) == true)
            {
                if (Session["user"] != null)
                {
                    lbn_Error.Visible = false;
                    lbn_Mensaje.Visible = true;
                    lbn_Mensaje.Text = "Ya iniciaste Seccion con este Usuario";
                }
                else
                {
                    if (CN_TipoUsuario.UsuarioAdmin(txt_email.Text, txt_Contra.Text) == true)
                    {
                        lbn_Error.Visible = false;
                        lbn_Mensaje.Visible = true;
                        lbn_Mensaje.Text = "Bienvenido";
                        Session["user"] = txt_email.Text;
                        Response.Redirect("/AdminIndex.aspx");
                    }
                    else
                    {
                        lbn_Error.Visible = false;
                        lbn_Mensaje.Visible = true;
                        lbn_Mensaje.Text = "Usuario";
                        Session["user"] = txt_email.Text;
                        Response.Redirect("/UsuarioIndex.aspx");
                    }
                }
                
            }
            else if (CN_Usuario.VerificarUsuario(txt_email.Text) == false && CN_Usuario.VerificarContra(txt_Contra.Text) == true)
            {
                Session["intento"] = Convert.ToString(Convert.ToInt32(Session["intento"])+1);
                if (Convert.ToInt32(Session["intento"]) <= 3)
                {
                    lbn_Error.Visible = false;
                    lbn_Mensaje.Visible = true;
                    lbn_Mensaje.Text = "Intento numero " + Convert.ToInt32(Session["intento"]) + " de 3";
                }
                else
                {
                    lbn_Error.Visible = true;
                    lbn_Mensaje.Visible = false;
                    lbn_Error.Text = "Numero de Intentos exedido";
                    Session["intento"] = 4;
                }
            }
            else if (CN_Usuario.VerificarUsuario(txt_email.Text) == true && CN_Usuario.VerificarContra(txt_Contra.Text) == false)
            {
                Session["intento"] = Convert.ToString(Convert.ToInt32(Session["intento"]) + 1);
                if (Convert.ToInt32(Session["intento"]) <= 3)
                {
                    lbn_Error.Visible = false;
                    lbn_Mensaje.Visible = true;
                    lbn_Mensaje.Text = "Intento numero " + Convert.ToInt32(Session["intento"]) + " de 3";
                }
                else
                {
                    lbn_Error.Visible = true;
                    lbn_Mensaje.Visible = false;
                    lbn_Error.Text = "Numero de Intentos exedido";
                    Session["intento"] = 4;
                }
            }
            else {              
                lbn_Error.Visible = true;
                lbn_Mensaje.Visible = false;
                lbn_Error.Text = "El usuario no existe";
            }
        }
    }
}