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
        public string? Nome { get; set; }
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

        // Inserir categoria 
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType =  System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spnome", Sigla);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    
       
       // Obter por Id
        public static Categoria ObterPorId(int id)
        {
            Categoria categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categorias where id = {id}"; 
            var dr = cmd.ExecuteReader();
            while (dr.Read())

            { 
                categoria = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
           
            return categoria;
        }

            // Obter Lista
            public static List<Categoria> ObterLista()
        {
            List<Categoria> categorias = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from categoria order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())  
            {
                categorias.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));
            }
            return categorias;
        }
        // Atualizar ou alterar 
        public bool Atualizar()
        {
            bool resposta = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_cateoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome",Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            if(cmd.ExecuteNonQuery() > 0)
            {
                cmd.Connection.Close();
                resposta = true;
            }
            return resposta;
        }

        // Deletar 
        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType |= System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_categoria_delete";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}

    

