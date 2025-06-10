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
            public string? Codigo { get; set; }
            public TipoDesconto Tipo { get; set; }
            public decimal Valor { get; set; }
            public DateTime ValidoDe { get; set; }
            public DateTime ValidoAte { get; set; }
            public bool Acumulativo { get; set; }


            public CupomDesconto(string? codigo, TipoDesconto tipo, decimal valor, DateTime validoDe, DateTime validoAte, bool acumulativo)
            {
                Codigo = codigo;
                Tipo = tipo;
                Valor = valor;
                ValidoDe = validoDe;
                ValidoAte = validoAte;
                Acumulativo = acumulativo;
            }

            public CupomDesconto() // Construtor vazio
            {
                Codigo = string.Empty;
                Tipo = TipoDesconto.Percentual;
                Valor = 0;
                ValidoDe = DateTime.Now;
                ValidoAte = DateTime.Now.AddDays(30);
                Acumulativo = false;
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
                    TipoDesconto.Percentual => valorOriginal - (valorOriginal * (Valor / 100)),
                    TipoDesconto.ValorFixo => Math.Max(0, valorOriginal - Valor),
                    _ => valorOriginal
                };
            }
        }

    }
}
