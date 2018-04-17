using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Avaliacao_Mariana
{
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }

        private void CadCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "MariTEC", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                e.Cancel = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Campos foram limpos ", "MariTEC");
        }

        private void LimparCampos()
        {
            txbNome.Text = "";
            txbCPF.Text = "";
            txbTelefone.Text = "";
            txbEndereco.Text = "";
            txbBairro.Text = "";
            txbDtNasc.Text = "";
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            string cel = "";

            if (ckbJ5.Checked)
            {
                {
                    cel = "1";
                }
                if (ckbMotoG.Checked)
                {
                    cel = "2";
                }
                if (ckbZen.Checked)
                {
                    cel = "3";
                }
                if (cbkIphone.Checked)
                {
                    cel = "4";
                }


                // Validação
                if (txbNome.Text == "" || txbCPF.Text == "" || txbTelefone.Text == "" || txbEndereco.Text == "" || txbBairro.Text == "" || txbDtNasc.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos", "MariTEC");
                }
                else
                {
                    //Salvar info no BD

                    string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=Avaliacao;Data Source=LAB-08-14;password=info211";

                    SqlConnection conexaoBanco = new SqlConnection(conexao);

                    conexaoBanco.Open();

                    string comandoSQL = "insert into tbCliente values ('" + txbNome.Text + "', '" + txbCPF.Text + "', '" + txbTelefone.Text + "', '" + txbEndereco.Text + "', '" + txbBairro.Text + "', '" + txbDtNasc.Text + "', ' " + cel + "')";

                    SqlCommand execucaoSQL = new SqlCommand(comandoSQL, conexaoBanco);
                    execucaoSQL.ExecuteNonQuery();

                    conexaoBanco.Close();

                    MessageBox.Show("Cadastro realizado", "MariTEC");
                    LimparCampos();
                }
            }
        }
    }
}
