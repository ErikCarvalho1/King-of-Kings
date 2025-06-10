using KingoOfKingsClass;
using Org.BouncyCastle.Crypto.Prng;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KingOfKingsClass
{
    public class Fornecedor
    {
 

        public int Id { get; set; }
        public string Razaosocial { get; set; }
        public string Fantasia { get; set; }
        public string Cnpj { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        
        public Fornecedor() { }


        public Fornecedor(int id, string razaosocial, string fantasia, string cnpj, string telefone,string contado, string email)
        {
            Id = id;
            Razaosocial = razaosocial;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contado;
            Telefone = telefone;
            Email = email;
        }
        public Fornecedor(string razaosocial, string fantasia, string cnpj,string contado , string telefone, string email)// inserir
        {
            
            Razaosocial = razaosocial;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contado;
            Telefone = telefone;
            Email = email;
        }
        public Fornecedor (string fantasia,string contato,string telefone, string email)// Atualizar
        {

            
            Fantasia = fantasia;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }
        public void inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spfornecedor_atualizar";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("sprazao_social", Razaosocial);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcnpj", Cnpj);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("spemail", Email);
            bool atualizado = cmd.ExecuteNonQuery() > 0 ? true : false;
            cmd.Connection.Close();
           
        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spfornecedor_Atualizar";
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("spemail", Email);
            Id = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return cmd.ExecuteNonQuery() > 0;
        }
        public static Fornecedor ObeterporId(int id)
        {
          Fornecedor fornecedor = new();
          var cmd = Banco.Abrir();
          cmd.CommandText = $"select * from fornecedores where id = {id}";
          var dr = cmd.ExecuteReader();
            if ((dr.Read()))

            {
                fornecedor = new(

                    dr.GetInt32(0), // Id
                    dr.GetString(1), // Razaosocial
                    dr.GetString(2), // Fantasia
                    dr.GetString(3), // Cnpj
                    dr.GetString(4), // Contato
                    dr.GetString(5), // Telefone
                    dr.GetString(6)  // Email
                );
            }
            dr.Close();
            cmd.Connection.Close();
            return fornecedor;


        }
        public static List<Fornecedor> ObterLista()
        {
            List<Fornecedor> fornecedor= new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from fornecedor order by nome";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fornecedor.Add(new(
                    dr.GetInt32(0), 
                    dr.GetString(1), 
                    dr.GetString(2), 
                    dr.GetString(3), 
                    dr.GetString(4), 
                    dr.GetString(5), 
                    dr.GetString(6)
                              )
                   );

            }
            dr.Close();
            cmd.Connection.Close();
            return fornecedor;
        }
    }
}
