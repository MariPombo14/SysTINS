using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    // Classe Banco é a nossa classe de conexão 
    public static class Banco // static pois não precisaremos criar uma instância
                              // de Banco para conectar às nossas bases
    { 
      public static MySqlCommand Abrir() // método para abrir conexão  
                                         // classe que tem uma coleção de metodos do banco de dados (tudo do mysql)
        {
            string strcon = @"server=127.0.0.1;database=systinsdb01;user=root;password=";
            MySqlConnection cn = new(strcon);// objeto cn tem os dados da conexão // fluxao de  
          MySqlCommand cmd = new();
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (MySqlException ex) // catch pega o erro e mostra 
            {
                Console.WriteLine(ex.Message);
            }
            return cmd;
        }
    }
}
