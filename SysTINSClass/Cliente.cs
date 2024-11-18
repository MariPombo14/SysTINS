using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime DataNasc { get; set; }
        public  DateTime DataCad { get; set; }
        public bool Ativo { get; set; }
        public List<Endereco> Enderecos { get; set; }


        public Cliente()
        {
            List<Endereco> Enderecos = new(); 
        }

        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime datanasc, DateTime datacad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = datanasc;
            DataCad = datacad;
            Ativo = ativo;

        }

        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime datanasc, DateTime datacad, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = datanasc;
            DataCad = datacad;
            Ativo = ativo;
            //sem id
        }
        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime datanasc, bool ativo)
        {
            
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = datanasc;
            Ativo = ativo;
            // sem data de cadastro
        }
        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime datanasc)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = datanasc;
            // sem data de cadastro e sem ATIVO

        }

        public Cliente(int id, string? nome, string? telefone, DateTime datanasc)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            DataNasc = datanasc;
            // Sem data de cadastro, sem ativo,cpf e email

        }
        // Inserir Cliente

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            cmd.Parameters.AddWithValue("spdatacad", DataCad);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
         //Obter por Id
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from cliente where id = {id}";
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                cliente = new(
                     dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7)
                    );
            }
            return cliente;
        }
        public static List<Cliente> ObterLista()
        {
            List<Cliente> clientes = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientes.Add(new(
                   dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7)
                    ));
            }
            return clientes;
        }
        public bool Atualizar()
        {
            bool resposta = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.Connection.Close();
                resposta = true;
            }
            return resposta;
        }
        
    }
}
