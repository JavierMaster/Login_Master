using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginCalculator
{
    public partial class UsuarioIndex : System.Web.UI.Page
    {
        private static int signo = 0;
        private static int cambio = 0;
        protected void Page_Load(object sender, EventArgs e)
        {            
            txt_Pantalla.Text = null;
            Session.Timeout = 5;           
        }
        protected void btn_Tecla_Igual_Click(object sender, EventArgs e)
        {
            if (cambio == 1 && signo != 0)
            {
                if (signo == 1)
                {
                    int resultado = Convert.ToInt32(Session["valor"]) + Convert.ToInt32(Session["valor2"]);
                    Session["Resultado"] = Convert.ToString(Session["Resultado"] + " " + "= " + resultado);
                    txt_Pantalla.Text = null;
                    txt_Pantalla.Text = "Resultado es: " + Convert.ToString(Session["Resultado"]);
                    cambio = 0;
                    signo = 0;
                    Session["Resultado"] = null;
                    Session["valor"] = null;
                    Session["valor2"] = null;
                }
                else if (signo == 2)
                {
                    int resultado = Convert.ToInt32(Session["valor"]) - Convert.ToInt32(Session["valor2"]);
                    Session["Resultado"] = Convert.ToString(Session["Resultado"] + " " + "= " + resultado);
                    txt_Pantalla.Text = null;
                    txt_Pantalla.Text = "Resultado es: " + Convert.ToString(Session["Resultado"]);
                    cambio = 0;
                    signo = 0;
                    Session["Resultado"] = null;
                    Session["valor"] = null;
                    Session["valor2"] = null;
                }
                else if (signo == 3)
                {
                    int resultado = Convert.ToInt32(Session["valor"]) * Convert.ToInt32(Session["valor2"]);
                    Session["Resultado"] = Convert.ToString(Session["Resultado"] + " " + "= " + resultado);
                    txt_Pantalla.Text = null;
                    txt_Pantalla.Text = "Resultado es: " + Convert.ToString(Session["Resultado"]);
                    cambio = 0;
                    signo = 0;
                    Session["Resultado"] = null;
                    Session["valor"] = null;
                    Session["valor2"] = null;
                }
                else if (signo == 4)
                {
                    if (Convert.ToDouble(Session["valor2"]) == 0)
                    {
                        txt_Pantalla.Text = null;
                        txt_Pantalla.Text = "No existe la Division para 0.";
                        cambio = 0;
                        signo = 0;
                        Session["Resultado"] = null;
                        Session["valor"] = null;
                        Session["valor2"] = null;
                    }
                    else
                    {
                        double resultado = Convert.ToDouble(Session["valor"]) / Convert.ToDouble(Session["valor2"]);
                        Session["Resultado"] = Convert.ToString(Session["Resultado"] + " " + "= " + Math.Round(resultado, 4));
                        txt_Pantalla.Text = null;
                        txt_Pantalla.Text = "Resultado es: " + Convert.ToString(Session["Resultado"]);
                        cambio = 0;
                        signo = 0;
                        Session["Resultado"] = null;
                        Session["valor"] = null;
                        Session["valor2"] = null;
                    }
                }
                else if (signo == 5)
                {
                    double resultado = Math.Pow(Convert.ToDouble(Session["valor"]), Convert.ToDouble(Session["valor2"]));
                    Session["Resultado"] = Convert.ToString(Session["Resultado"] + " " + "= " + Math.Round(resultado, 4));
                    txt_Pantalla.Text = null;
                    txt_Pantalla.Text = "Resultado es: " + Convert.ToString(Session["Resultado"]);
                    cambio = 0;
                    signo = 0;
                    Session["Resultado"] = null;
                    Session["valor"] = null;
                    Session["valor2"] = null;
                }
                else
                {
                    double resultado = Math.Pow(Convert.ToDouble(Session["valor"]), 1 / Convert.ToDouble(Session["valor2"]));
                    Session["Resultado"] = "La raiz "+Convert.ToString(Session["valor2"]) + " de " + Convert.ToString(Session["valor"]) + " es: " + Math.Round(resultado, 4);
                    txt_Pantalla.Text = null;
                    txt_Pantalla.Text = "Resultado es: " + Convert.ToString(Session["Resultado"]);
                    cambio = 0;
                    signo = 0;
                    Session["Resultado"] = null;
                    Session["valor"] = null;
                    Session["valor2"] = null;
                }
            }
            else
            {
                txt_Pantalla.Text = null;
                txt_Pantalla.Text = "Elegir valores primero";
            }   
        }

        protected void btn_Tecla_9_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                Session["valor"] = Convert.ToString((Convert.ToUInt32(Session["valor"]) *10)+ 9);
            }
            else
            {
                Session["valor2"] = Convert.ToString((Convert.ToUInt32(Session["valor2"]) * 10) + 9);
            }
            if (Session["Resultado"] == null)
            {
                Session["Resultado"] = Session["valor"];
            }
            else
            {
                Session["Resultado"] = Convert.ToString(Session["Resultado"].ToString() + "" + 9);
            }            
            txt_Pantalla.Text = null;
            txt_Pantalla.Text = Convert.ToString(Session["Resultado"]);
        }

        protected void btn_Tecla_8_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                Session["valor"] = Convert.ToString((Convert.ToUInt32(Session["valor"]) * 10) + 8);
            }
            else
            {
                Session["valor2"] = Convert.ToString((Convert.ToUInt32(Session["valor2"]) * 10) + 8);
            }
            if (Session["Resultado"] == null)
            {
                Session["Resultado"] = Session["valor"];
            }
            else
            {
                Session["Resultado"] = Convert.ToString(Session["Resultado"].ToString() + "" + 8);
            }
            txt_Pantalla.Text = null;
            txt_Pantalla.Text = Convert.ToString(Session["Resultado"]);
        }

        protected void btn_Tecla_7_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                Session["valor"] = Convert.ToString((Convert.ToUInt32(Session["valor"]) * 10) + 7);
            }
            else
            {
                Session["valor2"] = Convert.ToString((Convert.ToUInt32(Session["valor2"]) * 10) + 7);
            }
            if (Session["Resultado"] == null)
            {
                Session["Resultado"] = Session["valor"];
            }
            else
            {
                Session["Resultado"] = Convert.ToString(Session["Resultado"].ToString() + "" + 7);
            }
            txt_Pantalla.Text = null;
            txt_Pantalla.Text = Convert.ToString(Session["Resultado"]);
        }

        protected void btn_Tecla_suma_Click(object sender, EventArgs e)
        {
            if (Session["valor"] == null)
            {
                txt_Pantalla.Text = null;
                txt_Pantalla.Text = "Elegir valores primero";
            }
            else
            {
                signo = 1;
                cambio = 1;
                Session["Resultado"] = Convert.ToString(Session["Resultado"] + " " + "+" + " ");
                txt_Pantalla.Text = null;
                txt_Pantalla.Text = Session["Resultado"].ToString();
            }

        }

        protected void btn_Tecla_resta_Click(object sender, EventArgs e)
        {
            if (Session["valor"] == null)
            {
                txt_Pantalla.Text = null;
                txt_Pantalla.Text = "Elegir valores primero";
            }
            else
            {
                signo = 2;
                cambio = 1;
                Session["Resultado"] = Convert.ToString(Session["Resultado"] + " " + "-" + " ");
                txt_Pantalla.Text = null;
                txt_Pantalla.Text = Session["Resultado"].ToString();
            }
        }

        protected void btn_Tecla_4_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                Session["valor"] = Convert.ToString((Convert.ToUInt32(Session["valor"]) * 10) + 4);
            }
            else
            {
                Session["valor2"] = Convert.ToString((Convert.ToUInt32(Session["valor2"]) * 10) + 4);
            }
            if (Session["Resultado"] == null)
            {
                Session["Resultado"] = Session["valor"];
            }
            else
            {
                Session["Resultado"] = Convert.ToString(Session["Resultado"].ToString() + "" + 4);
            }
            txt_Pantalla.Text = null;
            txt_Pantalla.Text = Convert.ToString(Session["Resultado"]);
        }

        protected void btn_Tecla_5_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                Session["valor"] = Convert.ToString((Convert.ToUInt32(Session["valor"]) * 10) + 5);
            }
            else
            {
                Session["valor2"] = Convert.ToString((Convert.ToUInt32(Session["valor2"]) * 10) + 5);
            }
            if (Session["Resultado"] == null)
            {
                Session["Resultado"] = Session["valor"];
            }
            else
            {
                Session["Resultado"] = Convert.ToString(Session["Resultado"].ToString() + "" + 5);
            }
            txt_Pantalla.Text = null;
            txt_Pantalla.Text = Convert.ToString(Session["Resultado"]);
        }

        protected void btn_Tecla_6_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                Session["valor"] = Convert.ToString((Convert.ToUInt32(Session["valor"]) * 10) + 6);
            }
            else
            {
                Session["valor2"] = Convert.ToString((Convert.ToUInt32(Session["valor2"]) * 10) + 6);
            }
            if (Session["Resultado"] == null)
            {
                Session["Resultado"] = Session["valor"];
            }
            else
            {
                Session["Resultado"] = Convert.ToString(Session["Resultado"].ToString() + "" + 6);
            }
            txt_Pantalla.Text = null;
            txt_Pantalla.Text = Convert.ToString(Session["Resultado"]);
        }

        protected void btn_Tecla_multi_Click(object sender, EventArgs e)
        {
            if (Session["valor"] == null)
            {
                txt_Pantalla.Text = null;
                txt_Pantalla.Text = "Elegir valores primero";
            }
            else
            {
                signo = 3;
                cambio = 1;
                Session["Resultado"] = Convert.ToString(Session["Resultado"] + " " + "X" + " ");
                txt_Pantalla.Text = null;
                txt_Pantalla.Text = Session["Resultado"].ToString();
            }
        }

        protected void btn_Tecla_division_Click(object sender, EventArgs e)
        {
            if (Session["valor"] == null)
            {
                txt_Pantalla.Text = null;
                txt_Pantalla.Text = "Elegir valores primero";
            }
            else
            {
                signo = 4;
                cambio = 1;
                Session["Resultado"] = Convert.ToString(Session["Resultado"] + " " + "/" + " ");
                txt_Pantalla.Text = null;
                txt_Pantalla.Text = Session["Resultado"].ToString();
            }
        }

        protected void btn_Tecla_1_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                Session["valor"] = Convert.ToString((Convert.ToUInt32(Session["valor"]) * 10) + 1);
            }
            else
            {
                Session["valor2"] = Convert.ToString((Convert.ToUInt32(Session["valor2"]) * 10) + 1);
            }
            if (Session["Resultado"] == null)
            {
                Session["Resultado"] = Session["valor"];
            }
            else
            {
                Session["Resultado"] = Convert.ToString(Session["Resultado"].ToString() + "" + 1);
            }
            txt_Pantalla.Text = null;
            txt_Pantalla.Text = Convert.ToString(Session["Resultado"]);
        }

        protected void btn_Tecla_2_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                Session["valor"] = Convert.ToString((Convert.ToUInt32(Session["valor"]) * 10) + 2);
            }
            else
            {
                Session["valor2"] = Convert.ToString((Convert.ToUInt32(Session["valor2"]) * 10) + 2);
            }
            if (Session["Resultado"] == null)
            {
                Session["Resultado"] = Session["valor"];
            }
            else
            {
                Session["Resultado"] = Convert.ToString(Session["Resultado"].ToString() + "" + 2);
            }
            txt_Pantalla.Text = null;
            txt_Pantalla.Text = Convert.ToString(Session["Resultado"]);
        }

        protected void btn_Tecla_3_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                Session["valor"] = Convert.ToString((Convert.ToUInt32(Session["valor"]) * 10) + 3);
            }
            else
            {
                Session["valor2"] = Convert.ToString((Convert.ToUInt32(Session["valor2"]) * 10) + 3);
            }
            if (Session["Resultado"] == null)
            {
                Session["Resultado"] = Session["valor"];
            }
            else
            {
                Session["Resultado"] = Convert.ToString(Session["Resultado"].ToString() + "" + 3);
            }
            txt_Pantalla.Text = null;
            txt_Pantalla.Text = Convert.ToString(Session["Resultado"]);
        }

        protected void btn_Tecla_potencia_Click(object sender, EventArgs e)
        {
            if (Session["valor"] == null)
            {
                txt_Pantalla.Text = null;
                txt_Pantalla.Text = "Elegir valores primero";
            }
            else
            {
                signo = 5;
                cambio = 1;
                Session["Resultado"] = Convert.ToString(Session["Resultado"] + " " + "^" + " ");
                txt_Pantalla.Text = null;
                txt_Pantalla.Text = Session["Resultado"].ToString();
            }
        }

        protected void btn_Tecla_raiz_Click(object sender, EventArgs e)
        {
            if (Session["valor"] == null)
            {
                txt_Pantalla.Text = null;
                txt_Pantalla.Text = "Elegir valores primero";
            }
            else
            {
                signo = 6;
                cambio = 1;
                Session["Resultado"] = Convert.ToString(Session["Resultado"] + " " + "Raiz" + " ");
                txt_Pantalla.Text = null;
                txt_Pantalla.Text = Session["Resultado"].ToString();
            }
        }

        protected void btn_Tecla_Borrar_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = null;
            Session["valor"] = null;
            Session["Resultado"] = null;
            Session["valor2"] = null;
        }

        protected void btn_Tecla_0_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                Session["valor"] = Convert.ToString((Convert.ToUInt32(Session["valor"]) * 10) + 0);
            }
            else
            {
                Session["valor2"] = Convert.ToString((Convert.ToUInt32(Session["valor2"]) * 10) + 0);
            }
            if (Session["Resultado"] == null)
            {
                Session["Resultado"] = Session["valor"];
            }
            else
            {
                Session["Resultado"] = Convert.ToString(Session["Resultado"].ToString() + "" + 0);
            }
            txt_Pantalla.Text = null;
            txt_Pantalla.Text = Convert.ToString(Session["Resultado"]);
        }

        protected void btn_Tecla_punto_Click(object sender, EventArgs e)
        {

        }

        
    }
}