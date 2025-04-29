using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using KingoOfKingsClass;
using System.ComponentModel.DataAnnotations;

namespace KingoOfKingsClass
{
    public class Usuario

    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf_cnpj { get; set; }
        public string Email { get; set; }
        public string Tipo_Usuario { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criado_em { get; set; }
        public string Text1 { get; }
        public string Text2 { get; }
        public string Text3 { get; }
        public string Text4 { get; }
        public string Text5 { get; }

        public Usuario() { }

        
        public Usuario(int id, string nome, string cpf_cnpj, string email,
            string tipo_Usuario, string senha, bool ativo, DateTime criado_em) // Construtor para Cadastro
        {
            Id = id;
            Nome = nome;
            Cpf_cnpj = cpf_cnpj;
            Email = email;
            Tipo_Usuario = tipo_Usuario;
            Senha = senha;
            Ativo = ativo;
            Criado_em = criado_em;
        }

        public Usuario(int id, string nome, string senha, bool ativo)// Construtor para Login
        {
            Id = id;
            Nome = nome; ;
            Senha = senha;
            Ativo = ativo;
        }

        public Usuario(int id, string nome,string cpf_cnpj, string email,string tipo_Usuario, string senha, bool ativo)// Cadastro
        {
            Id = id;
            Nome = nome; ;
            Cpf_cnpj = cpf_cnpj;
            Email = email;
            Tipo_Usuario = tipo_Usuario;
            Senha = senha;
            Ativo = ativo;
           
           

        }
        public Usuario( string nome, string cpf_cnpj, string email, string tipo_Usuario, string senha)// Cadastro
        {
           
            Nome = nome; ;
            Cpf_cnpj = cpf_cnpj;
            Email = email;
            Tipo_Usuario = tipo_Usuario;
            Senha = senha;
         



        }


        public static Usuario EfetuarLogin(string email, string senha) // Método para efetuar login
        {
            Usuario usuario = new Usuario();
            string sql = $"SELECT * FROM usuarios WHERE email = '{email}' AND senha = MD5('{senha}')";

            var cn = Banco.Abrir();
            cn.CommandText = sql;
            //cn.Parameters.AddWithValue("@Email", email);
            //cn.Parameters.AddWithValue("@senha", senha);

            var dr = cn.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(5),
                dr.GetBoolean(6)
                    );
               

            }
            return usuario;


        }
        public void inserir() // metodo para inserir Usuario 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = $"INSERT INTO usuarios (id, nome, cpf_cnpj, email, tipo_Usuario, senha, ativo) " +
                   $"VALUES (0,'{Nome}', '{Cpf_cnpj}', '{Email}', '{Tipo_Usuario}', MD5('{Senha}'), 1)";

            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT  LAST_INSERT_ID()";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
    }

}
