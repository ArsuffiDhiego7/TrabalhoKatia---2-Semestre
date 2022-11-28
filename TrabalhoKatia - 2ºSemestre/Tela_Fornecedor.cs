using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoKatia___2ºSemestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Fornecedor fornecedor = new Fornecedor();
        Banco banco = new Banco();
        DataTable dt;
        Conexao conexao = new Conexao();    


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            if (txbCnpj.Text == String.Empty || txbEmail.Text == String.Empty || txbRazaoS.Text == String.Empty | txbTelefone.Text == String.Empty || txbInscricao.Text == String.Empty || txbNomeF.Text == String.Empty)
            {
                MessageBox.Show("Preencha todos os Campos por favor...", "Mensagem de aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                fornecedor.Cnpj = int.Parse(txbCnpj.Text);
                fornecedor.Email = txbEmail.Text;
                fornecedor.Telefone = txbTelefone.Text;
                fornecedor.Nome_fantasia = txbNomeF.Text;
                fornecedor.Razao_social = txbRazaoS.Text;
                fornecedor.Inscricao_estadual = txbInscricao.Text;
                banco.Inserir(fornecedor);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = Banco.Select_fornecedores();
            dataGrid_fornecedores.DataSource = dt;
        }
    }
}
