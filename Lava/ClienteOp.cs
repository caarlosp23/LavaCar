using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lava
{
    public class ClienteOp : Cliente
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string dr;
        public string mensagem = "";
        public void GravarCliente()
        {
            cmd.CommandText = "insert into CAD_Cliente(Identificacao, CpfCnpj,Nome,Telefone,CEP,Email,Rua, NumeroEndereco," +
                " Bairro, Complemento, Cidade, Estado, DataHoraCadastro)" +
             "values (@Identificacao, @CpfCnpj,@Nome,@Telefone,@CEP,@Email,@Rua,@NumeroEndereco,@Bairro" +
             ",@Complemento,@Cidade,@Estado,@DataHoraCadastro)";
            //parametros
            cmd.Parameters.AddWithValue("@Identificacao", Identificacao);
            cmd.Parameters.AddWithValue("@CpfCnpj", CpfCnpj);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            cmd.Parameters.AddWithValue("@CEP", CEP);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Rua", Rua);
            cmd.Parameters.AddWithValue("@NumeroEndereco", NumeroEndereco);
            cmd.Parameters.AddWithValue("@Bairro", Bairro);
            cmd.Parameters.AddWithValue("@Complemento", Complemento);
            cmd.Parameters.AddWithValue("@Cidade", Cidade);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@DataHoraCadastro", DataHoraCadastro);

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

        public ClienteOp BuscaCliente(string cpf)
        {
            string mensagem = "";
            Conexao bd = new Conexao();

            try
            {
                SqlConnection cn = bd.conectar();
                SqlCommand command = new SqlCommand("select * from cad_cliente",
                    cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(2) == cpf)
                    {
                        Id = reader.GetInt32(0);
                        Identificacao = reader.GetInt32(1);
                        CpfCnpj = reader.GetString(2);
                        Nome = reader.GetString(3);
                        Telefone = reader.GetString(4);
                        CEP = reader.GetString(5);
                        Email = reader.GetString(6);
                        Rua = reader.GetString(7);
                        NumeroEndereco = reader.GetString(8);
                        Bairro = reader.GetString(9);
                        Complemento = reader.GetString(10);
                        Cidade = reader.GetString(11);
                        Estado = reader.GetString(12);

                        return this;
                    }
                }
                mensagem = "Usuario não cadastrado!";
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
        public bool excluirCliente()
        {
            Conexao bd = new Conexao();

            SqlConnection cn = bd.conectar();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from cad_cliente where id = @id";
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
        public bool atualizarCliente()
        {
            Conexao bd = new Conexao();

            SqlConnection cn = bd.conectar();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update cad_cliente set Identificacao = @Identificacao, " +
                "CpfCnpj = @CpfCnpj, Nome = @Nome ,Telefone = @Telefone,CEP = @CEP,Email = @Email,Rua = @Rua," +
                "NumeroEndereco = @NumeroEndereco,Bairro = @Bairro,Complemento = @Complemento,Cidade = @Cidade," +
                "Estado = @Estado where id = @id";

            cmd.Parameters.Add("@Id", SqlDbType.Int);
            cmd.Parameters.Add("@Identificacao", SqlDbType.VarChar);
            cmd.Parameters.Add("@CpfCnpj", SqlDbType.VarChar);
            cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@Telefone", SqlDbType.VarChar);
            cmd.Parameters.Add("@CEP", SqlDbType.VarChar);
            cmd.Parameters.Add("@Email", SqlDbType.VarChar);
            cmd.Parameters.Add("@Rua", SqlDbType.VarChar);
            cmd.Parameters.Add("@NumeroEndereco", SqlDbType.VarChar);
            cmd.Parameters.Add("@Bairro", SqlDbType.VarChar);
            cmd.Parameters.Add("@Complemento", SqlDbType.VarChar);
            cmd.Parameters.Add("@Cidade", SqlDbType.VarChar);
            cmd.Parameters.Add("@Estado", SqlDbType.VarChar);
            //cmd.Parameters.Add("@DataHoraCadastro", SqlDbType.VarChar);

            cmd.Parameters[0].Value = Id;
            cmd.Parameters[1].Value = Identificacao;
            cmd.Parameters[2].Value = CpfCnpj;
            cmd.Parameters[3].Value = Nome;
            cmd.Parameters[4].Value = Telefone;
            cmd.Parameters[5].Value = CEP;
            cmd.Parameters[6].Value = Email;
            cmd.Parameters[7].Value = Rua;
            cmd.Parameters[8].Value = NumeroEndereco;
            cmd.Parameters[9].Value = Bairro;
            cmd.Parameters[10].Value = Complemento;
            cmd.Parameters[11].Value = Cidade;
            cmd.Parameters[12].Value = Estado;


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

