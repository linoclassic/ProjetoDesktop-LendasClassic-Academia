using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTeste
{
    public static class Banco
    {
        //string conexão com banco de dados
        public static string db = "SERVER=localhost;USER=root;DATABASE=lendasclassic3.0"; //local


        //reconhecer banco de dados - biblioteca MySql.Data
        public static MySqlConnection conexao;

        //metodo para abrir conexão
        public static void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Open();
            }
            catch   
            {
                MessageBox.Show("Erro ao efetuar a conexão com o  banco de dados","ERRO AO CONECTAR");
            }
          
        }

        //metodo para fechar conexão
        public static void Desconectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Close();    
            }
            catch
            {

                MessageBox.Show("Erro ao desconectar o banco de dados", "ERRO AO DESCONECTAR");
            }
        }
    }
}
