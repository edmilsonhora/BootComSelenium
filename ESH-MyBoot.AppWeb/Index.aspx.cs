using ESH_MyBoot.AppWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ESH_MyBoot.AppWeb
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                lblErro.Text = string.Empty;

                using (var db = new MyContext())
                {
                    var obj = new Usuario()
                    {
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        CPF = txtCPF.Text,
                        Perfil = dropPerfil.SelectedItem.Value,
                        Sexo = dropSexo.SelectedItem.Value
                    };

                    db.Usuarios.Add(obj);
                    db.SaveChanges();
                }

                Limpar();
            }
            catch (Exception ex)
            {
                lblErro.Text = ex.Message;
            }
        }

        private void Limpar()
        {
            txtCPF.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNome.Text = string.Empty;
            dropPerfil.SelectedIndex = 0;
            dropSexo.SelectedIndex = 0;
        }
    }
}