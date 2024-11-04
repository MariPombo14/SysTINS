using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Nivel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Sigla{ get; set;} // ? podem receber vlaroes nulos

        public Nivel() { } // metodo construstor (new)
        public Nivel( string? nome, string? sigla)
        {
           
            Nome = nome;
            Sigla = sigla;
        }

        public Nivel(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        // Inserir 
        public void Inserir () // Inserir é o nome do metodo 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"Insert niveis (nome,sigla) values ('{Nome}','{Sigla}') "; // Cadastrando nivel
            cmd.ExecuteNonQuery();
            cmd.Connection.Close(); // nunca esquecer de fechar a conexão 
        }
        // Consultar por id 
        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text ;
            cmd.CommandText = $"select id, nome ,sigla from niveis where id = {id}"; // Ordem da consultar é a que será mostrado
                                                                                     // e voce deve mudar as posições abaixo (0),(1),(2)
            var dr = cmd.ExecuteReader();
            if(dr.Read()) // Quando eu sei que ele vai retornar nada ou 1 pelo menos

            {
               //nivel.Id = dr.GetInt32(0);
                //nivel.Nome = dr.GetString(1);
                //nivel.Sigla = dr.GetString(2);

                // Segunda forma de realizar
                nivel = new(dr.GetInt32(0),dr.GetString(1), dr.GetString(2));
            }
            cmd.Connection.Close();
            return nivel;// static (Nao preciso declara uma instancia para obter um metodo )
        }
        // Obter Lista
        public static List<Nivel> ObterLista()
        {
            List<Nivel> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from niveis order by nome asc";
            var dr = cmd.ExecuteReader();
            while(dr.Read()) // Para retorna mais de um valor 
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
            cmd.CommandType |= System.Data.CommandType.Text;// Se nao indicar nada é commandtext
            cmd.CommandText = $"update niveis set nome'{Nome}', sigla = '{Sigla}'where id = {Id}";
            return cmd.ExecuteNonQuery()>0?true:false;// executa tudo // querey(consulta)
            
           
        }

        // Deletar 
        public void Excluir () 
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"delete from niveis where id = {Id}";
            cmd.ExecuteNonQuery(); // classe é a implentação
        }
    }
}
