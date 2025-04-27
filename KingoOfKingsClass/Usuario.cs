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

namespace KingoOfKingsClass
{
    public class Usuario

    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Tipo_Usuario { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criado_em { get; set; }


        public Usuario() { }

        
        public Usuario(int id, string nome, string cpf, string email,
            string tipo_Usuario, string senha, bool ativo, DateTime criado_em) // Construtor para Cadastro
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
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

        public static Usuario EfetuarLogin(string nome, string senha) // Método para efetuar login
        {
            Usuario usuario = new Usuario();
            string sql = "SELECT * FROM usuarios WHERE nome = @Nome AND senha = MD5(@senha)";

            var cn = Banco.Abrir();
            cn.CommandText = sql;
            cn.Parameters.AddWithValue("@Nome", nome);
            cn.Parameters.AddWithValue("@senha", senha);

            var dr = cn.ExecuteReader();
            if (dr.Read())
            {
                dr.GetInt32(0);
                dr.GetString(1);
                dr.GetString(2);
                dr.GetBoolean(3);

            }
            return usuario;


        }
    }

}
