using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Doacao
{
    class DAOPessoa




    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public string resultado;
        //vetor
        public int[] vetorCodigoCliente;
        public string[] vetorEmail;
        public string[] vetorNome;
        public string[] vetorTelefone;
        public string[] vetorEndereco;
        public string[] vetorBrinquedos;
        public string[] vetorRoupas;
        public string[] vetorDinheiro;
        public string[] vetorAlimento;
        public int i;



        public DAOPessoa()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=DoacaoBD;Uid=root;password=;");
            try
            {
                conexao.Open();//Tentando conectar ao BD
            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);//Mandando mensagem de erro para o usuario
                conexao.Close();//Fechando a conexao com o bd
            }
        }//Fim DAOPessoa














        //========================================================== Metodos ====================================================================







        public void Inserir(string nome, string email, string telefone, string endereco, string brinquedos, string roupas, string dinheiro, string alimento)
        {
            try
            {
                //Preparar os dados para inserir no banco
                dados = "('','" + email + "','" + nome + "','" + telefone + "','" + endereco + "','" + brinquedos + "','" + roupas + "','" + dinheiro + "','" + alimento + "')";
                comando = "Insert into Cliente(codigoCliente, email, nome, telefone, endereco, brinquedos, roupas, dinheiro, alimento) values " + dados;

                //Executar o comando na base de dados
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                resultado = "" + sql.ExecuteNonQuery();
                if (resultado == "1")
                {
                    MessageBox.Show("Enviado com sucesso!\n\n" +
                        "Entraremos em contato em breve!\n\n");
                }
                else
                {
                    MessageBox.Show("Não Cadastrado!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do método inserir







        public void PreencherVetor()
        {
            string query = "select * from Cliente";


            vetorCodigoCliente = new int[100];
            vetorEmail = new string[100];
            vetorNome = new string[100];
            vetorTelefone = new string[100];
            vetorEndereco = new string[100];
            vetorBrinquedos = new string[100];
            vetorRoupas = new string[100];
            vetorDinheiro = new string[100];
            vetorAlimento = new string[100];


            for(i=0; i < 100; i++)
            {
                vetorCodigoCliente[i] = 0;
                vetorEmail[i] = "";
                vetorNome[i] = "";
                vetorTelefone[i] = "";
                vetorEndereco[i] = "";
                vetorBrinquedos[i] = "";
                vetorRoupas[i] = "";
                vetorDinheiro[i] = "";
                vetorAlimento[i] = "";
            }//Fim for
        }//fim do preencherVetor










        //=========================================== Botao Atualizar =================================================







        public string AtualizarBrinquedos(int cod)
        {
            try
            {
                string query = "update Cliente set brinquedos = sim" + "' where codigoCliente = '" + cod + "'";

                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                if (resultado == "1")
                {
                    return "Obrigado!";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
            return "Erro";
        
           
        }//fim do metodo AtualizarBrinquedos






        public string AtualizarAlimentos(int cod)
        {
            try
            {
                string query = "update Cliente set alimento = sim" + "' where codigoCliente = '" + cod + "'";

                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                if (resultado == "1")
                {
                    return "Obrigado!";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
            return "Erro";


        }//fim do metodo AtualizarAlimentos







        public string AtualizarRoupas(int cod)
        {
            try
            {
                string query = "update Cliente set roupas = sim" + "' where codigoCliente = '" + cod + "'";

                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                if (resultado == "1")
                {
                    return "Obrigado!";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
            return "Erro";


        }//fim do metodo AtualizarRoupas






        public string AtualizarDinheiro(int cod)
        {
            try
            {
                string query = "update Cliente set dinheiro = sim" + "' where codigoCliente = '" + cod + "'";

                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                if (resultado == "1")
                {
                    return "Obrigado!";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
            return "Erro";


        }//fim do metodo AtualizarDinheiro







        //=============================================================================================================






    }//Fim da classe
}//Fim do projeto
