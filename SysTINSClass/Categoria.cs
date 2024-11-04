using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Notice.Warning.Types;

namespace SysTINSClass
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Sigla { get; set; } 

        public Categoria() { } 
        public Categoria(string? nome, string? sigla)
        {

            Nome = nome;
            Sigla = sigla;
        }

        public Categoria(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public Categoria(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        // Inserir categoria 
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"Insert categoria (nome,sigla) values ('{Nome}','{Sigla}') "; 
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    
       
       // Obter por Id
        public static Categoria ObterPorId(int id)
        {
            Categoria categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select id, nome ,sigla from niveis where id = {id}"; 
            var dr = cmd.ExecuteReader();
            if (dr.Read())

            { 
                categoria = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            cmd.Connection.Close();
            return categoria;
        }

            // Obter Lista
            public static List<Categoria> ObterLista()
        {
            List<Categoria> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from categoria order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())  
            {
                lista.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));
            }
            cmd.Connection.Close();
            return lista;
        }
        // Atualizar ou alterar 
        public bool Atualizar()
        {
            bool resposta = false;
            var cmd = Banco.Abrir();
            cmd.CommandType |= System.Data.CommandType.Text;
            cmd.CommandText = $"update categorias set nome'{Nome}', sigla = '{Sigla}'where id = {Id}";
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        // Deletar 
        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"delete from categoria where id = {Id}";
            cmd.ExecuteNonQuery();
        }
    }
}

    

