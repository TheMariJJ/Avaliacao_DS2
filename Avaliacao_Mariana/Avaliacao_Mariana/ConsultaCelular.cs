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
    public partial class ConsultaCelular : Form
    {
        public ConsultaCelular()
        {
            InitializeComponent();
        }

        private void btnCadCelular_Click(object sender, EventArgs e)
        {
            CadCelular telaCadCel = new CadCelular();
            telaCadCel.Show();
        }

        private void ConsultaCelular_Load(object sender, EventArgs e)
        {
            string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=Avaliacao;Data Source=LAB-08-14;password=info211";

            SqlConnection conexaoBanco = new SqlConnection(conexao);

            conexaoBanco.Open();

            string comandoSQL = "select * from tbCelular";

            SqlCommand execucaoSQL = new SqlCommand(comandoSQL, conexaoBanco);
            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL, conexaoBanco);
            DataSet datasetCliente = new DataSet();
            adaptador.Fill(datasetCliente);

            dtCelular.DataSource = datasetCliente;
            dtCelular.DataMember = datasetCliente.Tables[0].TableName;

            conexaoBanco.Close();
        }
    }
}
