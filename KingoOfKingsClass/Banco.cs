﻿using MySql.Data.MySqlClient;

namespace KingoOfKingsClass
{
    public class Banco
    {
        public static MySqlCommand Abrir()
        {


            MySqlCommand cmd = new();
            // string strConn = @"server=Localhost;database=kingofkings;user=root;password=";
            string strConn = @"server=10.91.47.88;database=kingofkings;user=root;password=123";
            MySqlConnection cn = new(strConn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cmd;
        }
    }
}
