using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lava
{
    public class VeiculoOp : Veiculo
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string dr;
        public string mensagem = "";
        public void GravarVeiculo()
        {
            cmd.CommandText = "insert into CAD_Veiculo( TipoVeiculo,Modelo, Cor, Placa, Cliente)" +
             "values (@TipoVeiculo,@Modelo,@Cor,@Placa,@Cliente)";
            //parametros
            cmd.Parameters.AddWithValue("@TipoVeiculo", TipoVeiculo);
            cmd.Parameters.AddWithValue("@Modelo", Modelo);
            cmd.Parameters.AddWithValue("@Cor", Cor);
            cmd.Parameters.AddWithValue("@Placa", Placa);
            cmd.Parameters.AddWithValue("@Cliente", Cliente);


            //conectar com o bd -- conexao 
            try
            {
                //conectar com o banco - conexao
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar msg de erro ou sucesso
                this.mensagem = "Dados salvos com sucesso!!";

            }
            catch (SqlException e)
            {
                this.mensagem = "Erro na conexão no banco de dados!";
            }
        }
        public VeiculoOp ConsultaVeiculo(int id)
        {
            Conexao bd = new Conexao();

            try
            {
                SqlConnection cn = bd.conectar();
                SqlCommand command = new SqlCommand("select * from cad_veiculo",
                    cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == Id)
                    {
                        this.Id = reader.GetInt32(0);
                        TipoVeiculo = reader.GetString(1);
                        Modelo = reader.GetString(2);
                        Cor = reader.GetString(3);
                        Placa = reader.GetString(4);
                        Cliente = reader.GetInt32(5).ToString();

                        return this;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.desconectar();
            }
        }
        public bool ExcluirVeiculo()
        {
            Conexao bd = new Conexao();

            SqlConnection cn = bd.conectar();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from cad_veiculo where id = @id";
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters[0].Value = Id;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.desconectar();
            }
        }
        public bool atualizarVeiculo()
        {
            Conexao bd = new Conexao();

            SqlConnection cn = bd.conectar();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update cad_veiculo set TipoVeiculo = @TipoVeiculo, " +
                "Modelo = @Modelo, Cor = @Cor ,Placa = @Placa,Cliente = @Cliente where id = @id";

            cmd.Parameters.Add("@Id", SqlDbType.Int);
            cmd.Parameters.Add("@TipoVeiculo", SqlDbType.VarChar);
            cmd.Parameters.Add("@Modelo", SqlDbType.VarChar);
            cmd.Parameters.Add("@Cor", SqlDbType.VarChar);
            cmd.Parameters.Add("@Placa", SqlDbType.VarChar);
            cmd.Parameters.Add("@Cliente", SqlDbType.Int);


            cmd.Parameters[0].Value = Id;
            cmd.Parameters[1].Value = TipoVeiculo;
            cmd.Parameters[2].Value = Modelo;
            cmd.Parameters[3].Value = Cor;
            cmd.Parameters[4].Value = Placa;
            cmd.Parameters[5].Value = Cliente;



            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.desconectar();
            }

        }
    }
}
