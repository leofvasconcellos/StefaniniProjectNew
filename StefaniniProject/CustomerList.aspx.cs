using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StefaniniProject
{
    public partial class CustomerList : System.Web.UI.Page
    {
        List<Exibicao> lista = new List<Exibicao>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Server.Transfer("Login.aspx", true);
            }
            else
            {
                ListItem liSelecione = new ListItem();
                liSelecione.Value = "0";
                liSelecione.Text = "Selecione";

                ddlGender.Items.Add(liSelecione);
                ddlCidade.Items.Add(liSelecione);
                ddlClassification.Items.Add(liSelecione);
                ddlRegion.Items.Add(liSelecione);
                ddlSeller.Items.Add(liSelecione);

                popularComboGenero();
                popularComboCidade();
                popularComboRegiao();
                popularComboClassificacao();
                popularComboVendedor();

                criarMassaParaConsulta();
            }
        }

        #region Combos

        private void popularComboGenero()
        {
            ListItem liMasculino = new ListItem();
            liMasculino.Value = "1";
            liMasculino.Text = "Masculino";

            ListItem liFeminino = new ListItem();
            liFeminino.Value = "2";
            liFeminino.Text = "Feminino";

            ddlGender.Items.Add(liMasculino);
            ddlGender.Items.Add(liFeminino);
        }

        private void popularComboCidade()
        {
            ListItem liPoa = new ListItem();
            liPoa.Value = "1";
            liPoa.Text = "Porto Alegre";

            ddlCidade.Items.Add(liPoa);
        }

        private void popularComboRegiao()
        {
            ListItem liSul = new ListItem();
            liSul.Value = "1";
            liSul.Text = "Sul";

            ddlRegion.Items.Add(liSul);
        }

        private void popularComboClassificacao()
        {
            // Itens a serem incluídos.
        }

        private void popularComboVendedor()
        {
            ListItem liSeller1 = new ListItem();
            liSeller1.Value = "1";
            liSeller1.Text = "Seller 1";

            ListItem liSeller2 = new ListItem();
            liSeller2.Value = "2";
            liSeller2.Text = "Seller 2";

            ddlSeller.Items.Add(liSeller1);
            ddlSeller.Items.Add(liSeller2);
        }

        #endregion

        #region Calendar

        protected void imbCalendar_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDataInicial.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }
        protected void imbCalendar2_Click(object sender, ImageClickEventArgs e)
        {
            Calendar2.Visible = true;
        }
        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            txtDataFinal.Text = Calendar2.SelectedDate.ToShortDateString();
            Calendar2.Visible = false;
        }

        #endregion

        private void criarMassaParaConsulta()
        {
            var data1 = "15/09/2017";
            var data2 = "11/11/2017";
            var data3 = "23/12/2017";
            var data4 = "07/08/2017";
            var data5 = "01/03/2017";

            lista.Add(new Exibicao() { nome = "Leandro", cidade = "Porto Alegre", genero = "Masculino", regiao = "Sul", telefone = "45 99999-4567", ultimaCompra = Convert.ToDateTime(data1), vendedor = "Seller 1" });
            lista.Add(new Exibicao() { nome = "Claudia", cidade = "Porto Alegre", genero = "Feminino", regiao = "Sul", telefone = "45 99999-0000", ultimaCompra = Convert.ToDateTime(data2), vendedor = "Seller 1" });
            lista.Add(new Exibicao() { nome = "Mariana", cidade = "Porto Alegre", genero = "Feminino", regiao = "Sul", telefone = "45 99999-1134", ultimaCompra = Convert.ToDateTime(data3), vendedor = "Seller 2" });
            lista.Add(new Exibicao() { nome = "Michel", cidade = "Porto Alegre", genero = "Masculino", regiao = "Sul", telefone = "45 99999-1154", ultimaCompra = Convert.ToDateTime(data4), vendedor = "Seller 2" });
            lista.Add(new Exibicao() { nome = "Julia", cidade = "Porto Alegre", genero = "Feminino", regiao = "Sul", telefone = "45 99999-1094", ultimaCompra = Convert.ToDateTime(data5), vendedor = "Seller 2" });
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Session.Remove("Usuario");
            Server.Transfer("Login.aspx", true);
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtDataInicial.Text = string.Empty;
            txtDataFinal.Text = string.Empty;

            ddlGender.Items.Clear();
            ddlCidade.Items.Clear();
            ddlClassification.Items.Clear();
            ddlRegion.Items.Clear();
            ddlSeller.Items.Clear();

            ListItem liSelecione = new ListItem();
            liSelecione.Value = "0";
            liSelecione.Text = "Selecione";

            ddlGender.Items.Add(liSelecione);
            ddlCidade.Items.Add(liSelecione);
            ddlClassification.Items.Add(liSelecione);
            ddlRegion.Items.Add(liSelecione);
            ddlSeller.Items.Add(liSelecione);

            popularComboGenero();
            popularComboCidade();
            popularComboRegiao();
            popularComboClassificacao();
            popularComboVendedor();

            grdConsulta.DataSource = null;
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
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

            Usuario user = (Usuario)Session["Usuario"];

            var listaRetorno = lista;
            if (!txtNome.Text.Equals(string.Empty))
            {
                listaRetorno = lista.Where(x => x.nome == txtNome.Text).ToList();
            }

            if (ddlGender.SelectedValue != "0")
            {
                listaRetorno = lista.Where(x => x.genero == ddlGender.SelectedItem.Text).ToList();
            }

            if (ddlCidade.SelectedValue != "0")
            {
                listaRetorno = lista.Where(x => x.cidade == ddlCidade.SelectedItem.Text).ToList();
            }

            if (ddlRegion.SelectedValue != "0")
            {
                listaRetorno = lista.Where(x => x.regiao == ddlRegion.SelectedItem.Text).ToList();
            }

            if (!txtDataInicial.Text.Equals(string.Empty))
            {
                listaRetorno = lista.Where(x => x.ultimaCompra == Convert.ToDateTime(txtDataInicial.Text)).ToList();

                if (!txtDataFinal.Text.Equals(string.Empty))
                {
                    listaRetorno = lista.Where(x => x.ultimaCompra >= Convert.ToDateTime(txtDataInicial.Text) && x.ultimaCompra <= Convert.ToDateTime(txtDataFinal.Text)).ToList();
                }
            }

            if (ddlClassification.SelectedValue != "0")
            {
                listaRetorno = lista.Where(x => x.classificacao == ddlClassification.SelectedItem.Text).ToList();
            }

            if (ddlSeller.SelectedValue != "0")
            {
                listaRetorno = lista.Where(x => x.vendedor == ddlSeller.SelectedItem.Text).ToList();
            }

            if (user.email.Equals(seller1.email) && user.senha.Equals(seller1.senha))
            {
                listaRetorno = lista.Where(x => x.vendedor == "Seller 1").ToList();
            }
            else if (user.email.Equals(seller2.email) && user.senha.Equals(seller2.senha))
            {
                listaRetorno = lista.Where(x => x.vendedor == "Seller 2").ToList();
            }

            grdConsulta.DataSource = listaRetorno;            

            if (!user.email.Equals(admin.email) && !user.senha.Equals(admin.senha))
            {
                grdConsulta.Columns.RemoveAt(7);
            }
            
            grdConsulta.DataBind();
        }
    }
}