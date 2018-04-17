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
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            CadCliente telaCadCleinte = new CadCliente();
            telaCadCleinte.Show();
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=Avaliacao;Data Source=LAB-08-14;password=info211";

            SqlConnection conexaoBanco = new SqlConnection(conexao);

            conexaoBanco.Open();

            string comandoSQL = "select * from tbCliente";
                
            SqlCommand execucaoSQL = new SqlCommand(comandoSQL, conexaoBanco);
            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL, conexaoBanco);
            DataSet datasetCliente = new DataSet();
            adaptador.Fill(datasetCliente);

            dtCliente.DataSource = datasetCliente;
            dtCliente.DataMember = datasetCliente.Tables[0].TableName;

            conexaoBanco.Close();
        }

        
    }
}
