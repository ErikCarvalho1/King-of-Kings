using ComercialTDSClass;
using KingoOfKingsClass;
using MySql.Data.MySqlClient;
using System;

namespace KingOfKingsClass
{
    /// <summary>
    /// Classe de domínio responsável por representar e persistir lançamentos de estoque.
    /// </summary>
    public class Estoque
    {
        // =============================
        // Propriedades
        // =============================
        public int Id { get; set; }

        public int ProdutoId { get; set; }


        public string NomeProduto { get; set; }

        public double Quantidade { get; set; }
        public DateTime DataUltimoMovimento { get; set; }

        // =============================
        // Construtores
        // =============================
        public Estoque() { }

        public Estoque(int id, int produtoId, double quantidade, DateTime dataUltimoMovimento)
        {
            Id = id;
            ProdutoId = produtoId;
            Quantidade = quantidade;
            DataUltimoMovimento = dataUltimoMovimento;
        }

        public Estoque(int produtoId, double quantidade, DateTime dataUltimoMovimento)
        {
            ProdutoId = produtoId;
            Quantidade = quantidade;
            DataUltimoMovimento = dataUltimoMovimento;
        }

        public Estoque(string nomeProduto, double quantidade, DateTime dataUltimoMovimento)
        {
            NomeProduto = nomeProduto?.Trim();
            Quantidade = quantidade;
            DataUltimoMovimento = dataUltimoMovimento;
        }

        // =============================
        // Métodos públicos
        // =============================
        public void Inserir()
        {
            // Se o Id do produto não foi definido, tenta buscar pelo nome.
            if (ProdutoId == 0 && !string.IsNullOrWhiteSpace(NomeProduto))
            {
                ProdutoId = BuscarIdProdutoPorNome(NomeProduto);
                if (ProdutoId == 0)
                    throw new InvalidOperationException("Produto não encontrado na tabela produtos.");
            }

            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_estoque_insert";
            cmd.Parameters.AddWithValue("spproduto_id", ProdutoId);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdata_ultimo_movimento", DataUltimoMovimento);
            cmd.ExecuteNonQuery();
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_estoque_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spproduto_id", ProdutoId);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdata_ultimo_movimento", DataUltimoMovimento);
            cmd.ExecuteNonQuery();
        }

        public void Deletar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_estoque_delete";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();
        }

        // =============================
        // Métodos auxiliares privados
        // =============================
        /// <summary>
        /// Busca o ID de um produto a partir do nome. Retorna 0 se não encontrar.
        /// </summary>
        private static int BuscarIdProdutoPorNome(string nome)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "SELECT id FROM produtos WHERE descricao = @nome LIMIT 1";
            cmd.Parameters.AddWithValue("@nome", nome);
            object result = cmd.ExecuteScalar();
            cmd.Connection?.Close();

            return result != null ? Convert.ToInt32(result) : 0;
        }
        public static List<Estoque> ObterLista()
        {
            List<Estoque> lista = new List<Estoque>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_estoque_listar";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Estoque estoque = new Estoque
                {
                    Id = Convert.ToInt32(dr["produto_id"]),
                    ProdutoId = Convert.ToInt32(dr["produto_id"]),
                    NomeProduto = dr["nome_produto"].ToString(),
                    Quantidade = Convert.ToDouble(dr["quantidade"]),
                    DataUltimoMovimento = Convert.ToDateTime(dr["data_ultimo_movimento"])
                };

                lista.Add(estoque);
            }

            dr.Close();
            cmd.Connection.Close();
            return lista;
        }
    }
}
