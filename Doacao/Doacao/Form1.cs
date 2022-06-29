using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doacao
{
    public partial class Form1 : Form
    {

        DAOPessoa pessoa;
        public string nome;
        public string email;
        public string telefone;
        public string endereco;
        public string brinquedos;
        public string roupas;
        public string dinheiro;
        public string alimento;

        public Form1()
        {
       
            InitializeComponent();
            pessoa = new DAOPessoa();//Abrindo conexao com bd
            
            brinquedos = "não";
            roupas = "não";
            dinheiro = "não";
            alimento = "não";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }//Textbox Nome


        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Maskedtxt TELEFONE


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//TXT Email

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//TXT Endereco


        public string ConsultarNome
        {

            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
                
        }

        public string ConsultarEmail
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string ConsultarTelefone
        {
            get
            {
                return this.telefone;
            }
            set
            {
                this.telefone = value;
            }
        }

        public string ConsultarEndereco
        {
            get
            {
                return this.endereco;
            }
            set
            {
                this.endereco = value;
            }
        }


        public void Coletar()
        {
            ConsultarNome = textBox1.Text;
            ConsultarEmail = textBox2.Text;
            ConsultarTelefone = maskedTextBox2.Text;
            ConsultarEndereco = textBox3.Text;
        }

        /////////////////////////////BOTÃO
        private void button1_Click(object sender, EventArgs e)
        {
            Coletar();
            pessoa.Inserir(ConsultarNome, ConsultarEmail, ConsultarTelefone, ConsultarEndereco, brinquedos, roupas, dinheiro, alimento);

        }//Botão concluir

        private void label5_Click(object sender, EventArgs e)
        {

        }












        private void button2_Click(object sender, EventArgs e)
        {
            if (brinquedos == "não")
            {
                brinquedos = "sim";
                MessageBox.Show("Você selecionou brinquedo!");
            }
            else
            {
                brinquedos = "não";
                MessageBox.Show("Você informou que NÃO doará brinquedos.");
            }
        }//BOTAO BRINQUEDO





        private void button3_Click(object sender, EventArgs e)
        {
            if (alimento == "não")
            {
                alimento = "sim";
                MessageBox.Show("Você selecionou alimento");
            }
            else
            {
                alimento = "não";
                MessageBox.Show("Você informou que NÃO doará alimento.");
            }
        }//BOTAO ALIMENTO

        private void button4_Click(object sender, EventArgs e)
        {
            if (roupas == "não")
            {
                roupas = "sim";
                MessageBox.Show("Você selecionou roupas");
            }
            else
            {
                roupas = "não";
                MessageBox.Show("Você informou que NÃO doará roupas.");
            }
        }//BOTAO ROUPAS

        private void button5_Click(object sender, EventArgs e)
        {
            if (dinheiro == "não")
            {
                dinheiro = "sim";
                MessageBox.Show("Você selecionou dinheiro");
            }
            else
            {
                dinheiro = "não";
                MessageBox.Show("Você informou que NÃO doará dinheiro.");
            }
        }//BOTAO DINHEIRO

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }//oque vc quer doar?
    }//Fim da classe
}//Fim do projeto
