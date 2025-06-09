using KingoOfKingsClass;
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
        public string Status { get; set; }
        public int Desconto { get; set; }

        public Pedidos(int id, Usuario usuarioId, Cliente cliente, DateTime dataPedido, string status, int desconto)
        {
            Id = id;
            UsuarioId = usuarioId;
            Cliente = cliente;
            DataPedido = dataPedido;
            Status = status;
            Desconto = desconto;
        }
        public Pedidos(Usuario usuarioId, Cliente cliente, DateTime dataPedido, string status, int desconto)
        {

            UsuarioId = usuarioId;
            Cliente = cliente;
            DataPedido = dataPedido;
            Status = status;
            Desconto = desconto;
        }
    }
}

