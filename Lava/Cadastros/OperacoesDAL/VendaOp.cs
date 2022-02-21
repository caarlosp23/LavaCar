using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lava
{
    public class VendaOp : Venda
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string dr;
        public string mensagem = "";
        public void GravarVenda()
        {
            cmd.CommandText = "insert into DOC_Venda( Numero, Servico, Cliente, Total, data)" +
             "values (@Numero,@Servico,@Cliente,@Total,@data)";
            //parametros
            cmd.Parameters.AddWithValue("@Numero", Numero);
            cmd.Parameters.AddWithValue("@Servico", Servico);
            cmd.Parameters.AddWithValue("@Cliente", Cliente);
            cmd.Parameters.AddWithValue("@Total", Total);
            dataDoc = DateTime.Now;
            cmd.Parameters.AddWithValue("@data", dataDoc);


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

        public bool ExcluirVenda()
        {
            Conexao bd = new Conexao();

            SqlConnection cn = bd.conectar();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from DOC_Venda where id = @id";
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
        public VendaOp ConsultaVenda(int id)
        {
            Conexao bd = new Conexao();

            try
            {
                SqlConnection cn = bd.conectar();
                SqlCommand command = new SqlCommand("select * from doc_venda",
                    cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == ID)
                    {
                        this.ID = reader.GetInt32(0);


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
    }
}