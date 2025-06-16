using KingoOfKingsClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfKingsClass
{
    class Caixa
    {
        public int Id { get; set; }
        public string Numero { get; set;  }
        public DateTime DataAbertura { get; set; }
        public decimal SaldoInicial { get; set; }
        public DateTime DataFechamneto { get; set; }
        public int Status { get; set; }

        public Caixa() { }

        public Caixa(int id, DateTime dataAbertura, decimal saldoInicial, int status)
        {
            Id = id;
            DataAbertura = dataAbertura;
            SaldoInicial = saldoInicial;
            Status = status;
        }

        public Caixa(DateTime dataAbertura, decimal saldoInicial, int status)
        {
            DataAbertura = dataAbertura;
            SaldoInicial = saldoInicial;
            Status = status;
        }
        public void AbrirCaixa()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_caixa_abrir";
            cmd.Parameters.AddWithValue("spdata_abertura", DataAbertura);
            cmd.Parameters.AddWithValue("spsaldo_inicial", SaldoInicial);
            cmd.Parameters.AddWithValue("spstatus", Status);
            cmd.ExecuteNonQuery();
        }

        public void FecharCaixa()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_caixa_fechar";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spdata_fechamento", DataFechamneto);
            cmd.ExecuteNonQuery();
        }

        public static Caixa ObterPorId(int id)
        {
            Caixa caixa = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from caixas where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                caixa = new Caixa(dr.GetInt32(0), dr.GetDateTime(1), dr.GetDecimal(2), dr.GetInt32(3));
            }
            dr.Close();
            cmd.Connection.Close();
            return caixa;
        }
        public static List<Caixa> ListarCaixas()
        {
            List<Caixa> caixas = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from caixas";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Caixa caixa = new Caixa(dr.GetInt32(0), dr.GetDateTime(1), dr.GetDecimal(2), dr.GetInt32(3));
                caixas.Add(caixa);
            }
            dr.Close();
            cmd.Connection.Close();
            return caixas;
        }
        public void
            Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_caixa_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spdata_abertura", DataAbertura);
            cmd.Parameters.AddWithValue("spsaldo_inicial", SaldoInicial);
            cmd.Parameters.AddWithValue("spstatus", Status);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_inserir_caixa";
            cmd.Parameters.AddWithValue("spnumero", Numero);
            Id = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Connection.Close();

        }
    }
}
