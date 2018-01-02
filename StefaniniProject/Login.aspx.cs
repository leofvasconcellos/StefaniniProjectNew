using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StefaniniProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtEmail.BorderColor = Color.Black;
            TxtSenha.BorderColor = Color.Black;
            lblMensagem.Text = String.Empty;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario admin = new Usuario();
            admin.email = "admin@sellseverything.com";
            admin.senha = "admin123";

            Usuario seller1 = new Usuario();
            seller1.email = "seller1@sellseverything.com";
            seller1.senha = "seller1123";

            Usuario seller2 = new Usuario();
            seller2.email = "seller2@sellseverything.com";
            seller2.senha = "seller2123";

            Usuario user = new Usuario();
            user.email = txtEmail.Text;
            user.senha = TxtSenha.Text;

            Session["Usuario"] = user;

            if (user.email.Equals(admin.email) && user.senha.Equals(admin.senha))
            {
                Server.Transfer("CustomerList.aspx", true);
            }
            else if ((user.email.Equals(seller1.email) && user.senha.Equals(seller1.senha)) || ((user.email.Equals(seller2.email) && user.senha.Equals(seller2.senha))))
            {
                Server.Transfer("CustomerList.aspx", true);
            }
            else
            {
                Session.Remove("Usuario");
                txtEmail.BorderColor = Color.Red;
                TxtSenha.BorderColor = Color.Red;
                lblMensagem.Text = "The email and/or password entered is invalid. Please try again.";
            }                                   
        }
    }
}