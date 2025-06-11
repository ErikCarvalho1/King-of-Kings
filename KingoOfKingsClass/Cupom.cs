using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfKingsClass
{
    public class Cupom
    {

     

        public class CupomDesconto
        {
           

            public string? Titulo { get; set; }
            public string? CupomTipo { get; set; }
            public int LimiteDeUso { get; set; }
            public string? Codigo { get; set; }
            public DateTime ValidoDe { get; set; }
            public DateTime ValidoAte { get; set; }
            public double ValorPedidoMinimo { get; set; } // Valor mínimo de compra para aplicar o cupom
            public double ValorMaximoDeDesconto { get; set; } // Valor maximo de desconto do cupom
            public double ValorDesconto { get; set; } // Valor máximo de compra para aplicar o cupom
            public string? Descricao { get; set; } // Descrição do cupom
            public double TpoDesconto { get; set; } // Tipo de desconto (0 = percentual, 1 = valor fixo)
            public TipoDesconto Tipo { get; set; }
            public bool Ativo { get; set; }

            public CupomDesconto(string? titulo, string? cupomTipo, int limiteDeUso, string? codigo, DateTime validoDe, DateTime validoAte, double valorPedidoMinimo, double valorMaximoDeDesconto, double valorDesconto, string? descricao, double tpoDesconto, TipoDesconto tipo, bool ativo)
            {
                Titulo = titulo;
                CupomTipo = cupomTipo;
                LimiteDeUso = limiteDeUso;
                Codigo = codigo;
                ValidoDe = validoDe;
                ValidoAte = validoAte;
                ValorPedidoMinimo = valorPedidoMinimo;
                ValorMaximoDeDesconto = valorMaximoDeDesconto;
                ValorDesconto = valorDesconto;
                Descricao = descricao;
                TpoDesconto = tpoDesconto;
                Tipo = tipo;
                Ativo = ativo;
            }


            public enum TipoDesconto
            {
                Percentual,
                ValorFixo
            }




            public bool EstaValido()
            {
                var agora = DateTime.Now;
                return agora >= ValidoDe && agora <= ValidoAte;
            }

            public decimal AplicarDesconto(decimal valorOriginal)
            {
                if (!EstaValido())
                    throw new InvalidOperationException("Cupom expirado ou ainda não válido.");

                return Tipo switch
                {
                    TipoDesconto.Percentual => valorOriginal - (valorOriginal * ( / 100)),
                    TipoDesconto.ValorFixo => Math.Max(0, valorOriginal - Valor),
                    _ => valorOriginal
                };
            }
        }

    }
}
