using KingoOfKingsClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfKingsClass
{
    public class Cupom
    {



        public class CupomDesconto
        {


            public int Id { get; set; } // Identificador único do cupom
            public string? Titulo { get; set; }
            public string? Codigo { get; set; }
            public string? CupomTipo { get; set; }
            public DateTime DataCriacao { get; set; } = DateTime.Now; // Data de criação do cupom
            public DateTime DataValidade { get; set; }
            public decimal ValorPedidoMinimo { get; set; } // Valor mínimo do pedido para aplicar o cupom
            public decimal ValorMaximoDeDesconto { get; set; } // Valor máximo de desconto permitido
            public decimal ValorMaximoPedido { get; set; } // Valor do desconto aplicado
            public decimal ValorDesconto { get; set; } // Valor do desconto aplicado
            public string? Descricao { get; set; } // Descrição do cupom
            public double TpoDesconto { get; set; } // Tipo de desconto (percentual ou valor fixo)
            public int ClienteId { get; set; } // ID do cliente associado ao cupom
            public int PedidoId { get; set; } // ID do pedido associado ao cupom
            public int revendedorId { get; set; } // ID do revendedor associado ao cupom


            public CupomDesconto(int id, string? titulo, string? codigo, string? cupomTipo, DateTime dataCriacao, DateTime dataValidade, decimal valorPedidoMinimo, decimal valorMaximoDeDesconto, decimal valorMaximoPedido, decimal valorDesconto, string? descricao, double tpoDesconto, int clienteId, int pedidoId, int revendedorId)
            {
                Id = id;
                Titulo = titulo;
                Codigo = codigo;
                CupomTipo = cupomTipo;
                DataCriacao = dataCriacao;
                DataValidade = dataValidade;
                ValorPedidoMinimo = valorPedidoMinimo;
                ValorMaximoDeDesconto = valorMaximoDeDesconto;
                ValorMaximoPedido = valorMaximoPedido;
                ValorDesconto = valorDesconto;
                Descricao = descricao;
                TpoDesconto = tpoDesconto;
                ClienteId = clienteId;
                PedidoId = pedidoId;
                this.revendedorId = revendedorId;
            }
            public CupomDesconto(string? titulo, string? codigo, string? cupomTipo, DateTime dataCriacao, DateTime dataValidade, decimal valorPedidoMinimo, decimal valorMaximoDeDesconto, decimal valorMaximoPedido, decimal valorDesconto, string? descricao, double tpoDesconto, int clienteId, int pedidoId, int revendedorId)
            {

                Titulo = titulo;
                Codigo = codigo;
                CupomTipo = cupomTipo;
                DataCriacao = dataCriacao;
                DataValidade = dataValidade;
                ValorPedidoMinimo = valorPedidoMinimo;
                ValorMaximoDeDesconto = valorMaximoDeDesconto;
                ValorMaximoPedido = valorMaximoPedido;
                ValorDesconto = valorDesconto;
                Descricao = descricao;
                TpoDesconto = tpoDesconto;
                ClienteId = clienteId;
                PedidoId = pedidoId;
                this.revendedorId = revendedorId;
            }
            public CupomDesconto(string? titulo, string? codigo, string? cupomTipo, DateTime dataCriacao, DateTime dataValidade, decimal valorPedidoMinimo, decimal valorMaximoDeDesconto, decimal valorMaximoPedido, decimal valorDesconto, string? descricao, double tpoDesconto)
            {

                Titulo = titulo;
                Codigo = codigo;
                CupomTipo = cupomTipo;
                DataCriacao = dataCriacao;
                DataValidade = dataValidade;
                ValorPedidoMinimo = valorPedidoMinimo;
                ValorMaximoDeDesconto = valorMaximoDeDesconto;
                ValorMaximoPedido = valorMaximoPedido;
                ValorDesconto = valorDesconto;
                Descricao = descricao;
                TpoDesconto = tpoDesconto;
             
            }

            public enum TipoDesconto
            {
                Percentual,
                ValorFixo
            }

            public void Inserir()
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_inserir_cupom";
                cmd.Parameters.AddWithValue("spid",Id );
                cmd.Parameters.AddWithValue("sptitulo", Titulo);
                cmd.Parameters.AddWithValue("spcodigo", Codigo);
                cmd.Parameters.AddWithValue("spcupomtipo", CupomTipo);
                cmd.Parameters.AddWithValue("spdatacriacao", DataCriacao);
                cmd.Parameters.AddWithValue("spdatavalidade", DataValidade);
                cmd.Parameters.AddWithValue("spvalorpedidominimo", ValorPedidoMinimo);
                cmd.Parameters.AddWithValue("spvalormaximodesconto", ValorMaximoDeDesconto);
                cmd.Parameters.AddWithValue("spvalormaximopedido", ValorMaximoPedido);
                cmd.Parameters.AddWithValue("spvalordesconto", ValorDesconto);
                cmd.Parameters.AddWithValue("spdescricao", Descricao);
                cmd.Parameters.AddWithValue("sptipodesconto", TpoDesconto);
                cmd.Parameters.AddWithValue("spclienteid", ClienteId);
                cmd.Parameters.AddWithValue("sppedidoid", PedidoId);
                cmd.Parameters.AddWithValue("sprevendedorid", revendedorId);
                // Executa o comando e obtém o ID do cupom inserido


                Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }


            public bool EstaValido()
            {
                var agora = DateTime.Now;
                return agora >= DataCriacao && agora <= DataValidade;
            }

            public decimal AplicarDesconto(decimal valorOriginal)
            {
                if (!EstaValido())
                    throw new InvalidOperationException("Cupom expirado ou ainda não válido.");

                if (valorOriginal < ValorPedidoMinimo)
                    throw new InvalidOperationException("Valor do pedido abaixo do mínimo para aplicar o cupom.");

                decimal descontoAplicado = CupomTipo switch
                {
                    "Percentual" => valorOriginal * ((decimal)TpoDesconto / 100),
                    "ValorFixo" => ValorDesconto,
                    _ => 0
                };

                // Aplicar limite máximo de desconto
                descontoAplicado = Math.Min(descontoAplicado, ValorMaximoDeDesconto);

                // Retornar o valor final com o desconto aplicado, sem ultrapassar o máximo permitido
                return Math.Max(0, valorOriginal - descontoAplicado);
            }
        }
    }
}