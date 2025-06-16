using KingoOfKingsClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace KingOfKingsClass
{
    public class Estoque // Métodos 
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public double Quantidade { get; set; }
        public DateTime DataUltimoMovimento { get; set; }




        public Estoque() { } //Métodos Construtor 

    


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

        public void Inserir() // Métodos Inserir
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_estoque_insert";
            cmd.Parameters.AddWithValue("spproduto_id", ProdutoId);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdata_ultimo_movimento", DataUltimoMovimento);
            cmd.ExecuteNonQuery();
        }
        public void Atualizar() //Métodos Atualizar
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
        public void Deletar() // Métodos Deletar
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_estoque_delete";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();
        }


    }
}
