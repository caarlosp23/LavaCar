using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lava
{
    public class ServicoOp : Servico
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string dr;
        public string mensagem = "";
        public void GravarServico()
        {
            cmd.CommandText = "insert into Cad_Servico( Servico,PrecoCusto, PrecoVenda)" +
             "values (@Servico,@PrecoCusto,@PrecoVenda)";
            //parametros
            cmd.Parameters.AddWithValue("@Servico", servico);
            cmd.Parameters.AddWithValue("@PrecoCusto", precoCusto);
            cmd.Parameters.AddWithValue("@PrecoVenda", precoVenda);



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
        public ServicoOp ConsultaServico(int id)
        {
            Conexao bd = new Conexao();

            try
            {
                SqlConnection cn = bd.conectar();
                SqlCommand command = new SqlCommand("select * from cad_servico",
                    cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == ID)
                    {
                        this.ID = reader.GetInt32(0);
                        servico = reader.GetString(1);
                        precoCusto = reader.GetDecimal(2);
                        precoVenda = reader.GetDecimal(3);
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
        public bool ExcluirServico()
        {
            Conexao bd = new Conexao();

            SqlConnection cn = bd.conectar();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from cad_servico where id = @id";
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters[0].Value = ID;

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
        public bool atualizarServico()
        {
            Conexao bd = new Conexao();

            SqlConnection cn = bd.conectar();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update cad_servico set servico = @servico, " +
                "precocusto = @precocusto, precovenda = @precovenda where id = @id";

            cmd.Parameters.Add("@Id", SqlDbType.Int);
            cmd.Parameters.Add("@servico", SqlDbType.VarChar);
            cmd.Parameters.Add("@precocusto", SqlDbType.Decimal);
            cmd.Parameters.Add("@precovenda", SqlDbType.Decimal);
            


            cmd.Parameters[0].Value = ID;
            cmd.Parameters[1].Value = servico;
            cmd.Parameters[2].Value = precoCusto;
            cmd.Parameters[3].Value = precoVenda;
           



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
