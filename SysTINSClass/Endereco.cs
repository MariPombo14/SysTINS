using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Endereco
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string ? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? TipoEndereco { get; set; }

        public Endereco(){}
        public Endereco(int id,Cliente cliente, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoendereco)
        {
            Id = id;
            Cliente = cliente;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoendereco;
        }
        public Endereco(Cliente cliente, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoendereco)
        {
            Cliente = cliente;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoendereco;
        }
        
            // Inserir categoria 
            public void Inserir()
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_categoria_insert";
                cmd.Parameters.AddWithValue("spid",Id);
                cmd.Parameters.AddWithValue("spcliente_id",Cliente.Id);
                cmd.Parameters.AddWithValue("spcep",Cep);
                cmd.Parameters.AddWithValue("splogradouro", Logradouro);
                cmd.Parameters.AddWithValue("spnumero", Numero);
                cmd.Parameters.AddWithValue("spnumero", Numero);
                cmd.Parameters.AddWithValue(" sptipo_endereco",TipoEndereco);
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }


            // Obter por Id
            public static Categoria ObterPorId(int id)
            {
                Categoria categoria = new();
                var cmd = Banco.Abrir();
                cmd.CommandText = $"select * from categorias where id = {Cliente.ObterPorId}";
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
                cmd.CommandText = $"sp_categoria_update";
                cmd.Parameters.AddWithValue("spid", Id);
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spsigla", Sigla);
                if (cmd.ExecuteNonQuery() > 0)
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
                cmd.CommandText = $"sp_endereco_delete";
                cmd.Parameters.AddWithValue("spid", Id);
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
    }




}
}
