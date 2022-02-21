﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace Lava
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //construtor
        public Conexao()
        {
            con.ConnectionString = "Data Source=localhost; Initial Catalog=LavaCarlos; User ID=usuario; password=senha;language=Portuguese; Trusted_Connection=true";
        }
        //metodo conectar 
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //metodo desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return;
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                conectar();

                SqlCommand command = new SqlCommand(sql, con);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);//adaptar preenche o datatable com os dados do command

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                desconectar();
            }
        }
    }
}
