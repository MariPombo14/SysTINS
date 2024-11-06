using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SysTINSClass
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Cod_barras { get; set; }
        public string? Descricao { get; set; }
        public double Valor_unit { get; set; }
        public string? Unidade_venda { get; set; }
        public Categoria Categoria_id { get; set; }
        public double Estoque_minimo { get; set; }
        public double Classe_desconto { get; set; }
        public DateTime Datacad { get; set; }


        public Produto() 
        {
            Categoria_id = new();
        }

         public Produto (int id, string cod_barras, string descricao, double valor_unit, string unidade_venda, Categoria categoria_id, double estoque_minimo, double classe_desconto, DateTime datacad) 
        {
            Id = id;
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unit = valor_unit;
            Unidade_venda = unidade_venda;
            Categoria_id = categoria_id;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;
            Datacad = datacad;
        }

        public Produto( string cod_barras, string descricao, double valor_unit, string unidade_venda, Categoria categoria_id, double estoque_minimo, double classe_desconto, DateTime datacad)
        {
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unit = valor_unit;
            Unidade_venda = unidade_venda;
            Categoria_id = categoria_id;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;
            Datacad = datacad;
        }

        public Produto(int id, string cod_barras, string descricao, double valor_unit, string unidade_venda, Categoria categoria_id, double classe_desconto)
        {
            Id = id;
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unit = valor_unit;
            Unidade_venda = unidade_venda;
            Categoria_id = categoria_id;
            Classe_desconto = classe_desconto;
        }

        // Inserir produto 
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras",Cod_barras);
            cmd.Parameters.AddWithValue("descricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", Valor_unit);
            cmd.Parameters.AddWithValue("spunidade_venda", Unidade_venda);
            cmd.Parameters.AddWithValue("spcategoria_id",Categoria_id);
            cmd.Parameters.AddWithValue("spestoque_minimo", Estoque_minimo);
            cmd.Parameters.AddWithValue("sPclasse_desconto", Classe_desconto);
              // Id = Convert.ToInt32 (cmd.Execute.Scalar());
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }

        // ObterporId
        public static Produto ObterporId(int id)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produto where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                produto = new(
                    dr.GetInt32(0), 
                    dr.GetString(1), 
                    dr.GetString(2), 
                    dr.GetDouble(3),
                    dr.GetString(4), 
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    dr.GetDateTime(9)
                    );
            }

            return produto;
        }
        // Classe busca pelo nome do produto
        public static List<Produto> ObterLista()
        {
            List<Produto> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produto order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                     dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    dr.GetDateTime(9))
                    );
            }
            return lista;
        }
        // Atualizar ou alterar 
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update"; 
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcod_barras", Cod_barras);
            cmd.Parameters.AddWithValue("descricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", Valor_unit);
            cmd.Parameters.AddWithValue("spunidade_venda", Unidade_venda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria_id);
            cmd.Parameters.AddWithValue("spestoque_minimo", Estoque_minimo);
            cmd.Parameters.AddWithValue("sPclasse_desconto", Classe_desconto);

            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
       
    }
}
