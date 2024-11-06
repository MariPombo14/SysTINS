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
            List<Endereco> enderecos = new();
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

        }
        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime datanasc, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = datanasc;
            Ativo = ativo;

        }
        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime datanasc)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = datanasc;
           

        }




    }
}
//id int(4) AI PK 
//nome varchar(100) 
//cpf char(11) 
//telefone char(14) 
//email varchar(60) 
//data_nasc date 
//data_cad timestamp 
//ativo bit(1)