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
        public int Cliente_id { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? TipoEndereco { get; set; }

        public Endereco() { }
        public Endereco(int id, int cliente_id, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoendereco)
        {
            Id = id;
            Cliente_id = cliente_id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoendereco;
        }
        public Endereco(int cliente_id, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoendereco)
        {
            Cliente_id = cliente_id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoendereco;
        }

        // Inserir Endereço 
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente_id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue(" sptipo_endereco", TipoEndereco);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


        // Obter por Id
        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from enderecos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())

            {
                endereco = new(
                dr.GetInt32(0),
                dr.GetInt32(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetString(5),
                dr.GetString(6),
                dr.GetString(7),
                dr.GetString(8)
                );
            }

            return endereco;
        }

        // Obter Lista
        public static List<Endereco> ObterListaPorClienteId(int id)
        {
            List<Endereco> enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from enderecos where id_cliente = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(new(
                dr.GetInt32(0),
                dr.GetInt32(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetString(5),
                dr.GetString(6),
                dr.GetString(7),
                dr.GetString(8))
                );
            }
            return enderecos;
        }
        // Atualizar ou alterar 
        public bool Atualizar()
        {
            bool resposta = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_endereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue(" sptipo_endereco", TipoEndereco);
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






