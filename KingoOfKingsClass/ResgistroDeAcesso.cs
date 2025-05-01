using KingoOfKingsClass;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KingOfKingsclass
{
        public class ResgistroDeAcesso
    {
        public int Id { get; set; }
       public int Usuario_Id { get; set; }
        public DateTime?  Entrada { get; set; }
        public DateTime? Saida { get; set; }

        public ResgistroDeAcesso() { }
        public ResgistroDeAcesso(int id, int usuario_id,DateTime entrada, DateTime saida) // Construtor para Registro de Acesso
        {
            Id = id;
            Usuario_Id = usuario_id;
            Entrada = entrada;
            Saida = saida;
        }
        public ResgistroDeAcesso(int usuario_Id,DateTime entrada, DateTime saida) // Construtor para Registro de Acesso
        {
            Usuario_Id = usuario_Id;
            Entrada = entrada;
            Saida = saida;
        }
        public void RegistrarAcesso()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "INSERT INTO RegistroDeAcesso(Usuario_Id, Entrada) VALUES(usuario_Id, NOW())"; 
            cmd.Parameters.AddWithValue("@Usuario_Id", Id);
            cmd.Parameters.AddWithValue("@entrada", DateTime.Now);
            cmd.ExecuteNonQuery();
            
            
            // Aqui você pode implementar a lógica para registrar o acesso no banco de dados
            // Por exemplo, inserir os dados de entrada e saída em uma tabela de registro de acesso
        }
        public void RegistrarSaida()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "UPDATE RegistroDeAcesso SET saida = @saida WHERE id = @id";
            cmd.Parameters.AddWithValue("@saida", Saida);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            // Aqui você pode implementar a lógica para registrar a saída no banco de dados
            // Por exemplo, atualizar os dados de saída na tabela de registro de acesso
        }
    }
}
