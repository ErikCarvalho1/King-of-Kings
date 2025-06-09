using KingoOfKingsClass;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfKingsClass
{
    public class Pedidos
    {


        public int Id { get; set; }
        public Usuario UsuarioId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataPedido { get; set; }
        public string? Status { get; set; }
        public double Desconto { get; set; }
        public List<ItemPedido> Items { get; set; }
        public Pedidos() { }

        public Pedidos(int id, Usuario usuarioId, Cliente cliente, DateTime dataPedido, string status, int desconto)
        {
            Id = id;
            UsuarioId = usuarioId;
            Cliente = cliente;
            DataPedido = dataPedido;
            Status = status;
            Desconto = desconto;
        }
        public Pedidos(Usuario usuarioId, Cliente cliente)// inserir CLiente
        {

            UsuarioId = usuarioId;
            Cliente = cliente;

        }
        public Pedidos(int id, string status, int desconto) //atualizar
        {
            Id = id;
            Status = status;
            Desconto = desconto;
        }
        public Pedidos(int id, Usuario usuarioId, Cliente cliente, string status, DateTime dataPedido, double desconto, List<ItemPedido> items) // listar pedido
        {
            Id = id;
            UsuarioId = usuarioId;
            Cliente = cliente;
            DataPedido = dataPedido;
            Desconto = desconto;
            Status = status;
            List<ItemPedido> Items = new List<ItemPedido>();


        }
        public void inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spusuarioid", UsuarioId.Id);
            cmd.Parameters.AddWithValue("spclienteid", Cliente.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spstatus", Status);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            bool atualizado = cmd.ExecuteNonQuery() > 0 ? true : false;
            cmd.Connection.Close();
            return atualizado;
        }
        public static Pedidos ObterPorId(int id)
        {
            Pedidos pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"seletc * from pedidos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos = new(
                    dr.GetInt32(0),
                    Usuario.ObterporId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                   
                    dr.GetDouble(5),
                    ItemPedido.ObterListaPorPedidoId(dr.GetInt32(0))
                    
                    );
                dr.Close();
                cmd.Connection.Close();

                return pedidos;
            }
        }
    }
}




