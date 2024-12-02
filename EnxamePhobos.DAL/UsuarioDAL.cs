using EnxamePhobos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EnxamePhobos.DAL
{
    public class UsuarioDAL : Conexao
    {
        string msg = $"Essa foi mais uma cagada que cometeram no meu codigo !!";

        //autenticarUsuario
        public UsuarioDTO AuthenticateUser(string nomeUser, string senhaUser)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Usuario WHERE NomeUsuario = @nomeUsuario AND SenhaUsuario = @senhaUsuario;", conn);
                cmd.Parameters.AddWithValue("@nomeUsuario", nomeUser);
                cmd.Parameters.AddWithValue("@senhaUsuario", senhaUser);
                dr = cmd.ExecuteReader();
                UsuarioDTO user = null; //ponteiro
                if (dr.Read())
                {
                    user = new UsuarioDTO();
                    user.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    user.NomeUsuario = dr["NomeUsuario"].ToString();
                    user.EmailUsuario = dr["EmailUsuario"].ToString();
                    user.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    user.DtNascUsuario = Convert.ToDateTime(dr["DtNascUsuario"]);
                    user.UsuarioTp = dr["UsuarioTp"].ToString();
                }
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception($"{msg} - {ex.Message}");
            }
            finally
            {
                Desconectar();
            }

        }

        //CRUD
        //Create
        public void CreateUser(UsuarioDTO user)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Usuario (NomeUsuario,EmailUsuario,SenhaUsuario,DtNascUsuario,UsuarioTp) VALUES (@NomeUsuario,@EmailUsuario,@SenhaUsuario,@DtNascUsuario,@UsuarioTp)", conn);
                cmd.Parameters.AddWithValue("@NomeUsuario", user.NomeUsuario);
                cmd.Parameters.AddWithValue("@EmailUsuario", user.EmailUsuario);
                cmd.Parameters.AddWithValue("SenhaUsuario", user.SenhaUsuario);
                cmd.Parameters.AddWithValue("@DtNascUsuario", user.DtNascUsuario);
                cmd.Parameters.AddWithValue("@UsuarioTp", user.UsuarioTp);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception($"{msg}{ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }

        //Read
        public List<UsuarioDTO> GetUser()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdUsuario,NomeUsuario,EmailUsuario,SenhaUsuario,DtNascUsuario,DescricaoTipoUsuario From Usuario INNER JOIN TipoUsuario ON UsuarioTP = IdTipoUsuario;", conn);
                dr = cmd.ExecuteReader();
                List<UsuarioDTO> listUser = new List<UsuarioDTO>();
                while (dr.Read())
                {
                    UsuarioDTO user = new UsuarioDTO();
                    user.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    user.NomeUsuario = dr["NomeUsuario"].ToString();
                    user.EmailUsuario = dr["EmailUsuario"].ToString();
                    user.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    user.DtNascUsuario = Convert.ToDateTime(dr["DtNascUsuario"]);
                    user.UsuarioTp = dr["DescricaoTipoUsuario"].ToString();
                    listUser.Add(user);
                }
                return listUser;
            }
            catch (Exception ex)
            {

                throw new Exception($"{msg}{ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }

        //UPDATE
        public void UpdateUser(UsuarioDTO user)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Usuario SET NomeUsuario = '@NomeUsuario',EmailUsuario = '@EmailUsuario',SenhaUsuario = '@SenhaUsuario', \r\nDtNascUsuario = '@DtNascUsuarioUsuario', UsuarioTp =  '@UsuarioTp' WHERE IdUsuario = '@IdUsuario')", conn);
                cmd.Parameters.AddWithValue("@NomeUsuario", user.NomeUsuario);
                cmd.Parameters.AddWithValue("@EmailUsuario", user.EmailUsuario);
                cmd.Parameters.AddWithValue("SenhaUsuario", user.SenhaUsuario);
                cmd.Parameters.AddWithValue("@DtNascUsuario", user.DtNascUsuario);
                cmd.Parameters.AddWithValue("@UsuarioTp", user.UsuarioTp);
                //passando o id para condição WHERE do comando SQL
                cmd.Parameters.AddWithValue("@IdUsuario", user.IdUsuario);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception($"{msg} - {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }

        //Delete
        public void DeleteUser(int IdUser)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Usuario WHERE IdUsuario = '@IdUsuario';", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", IdUser);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"{msg} - {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }

        //SearchById
        public UsuarioDTO Search(int idUser)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Usuario WHERE IdUsuario = @IdUsuario;", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUser);
                dr = cmd.ExecuteReader();
                UsuarioDTO user = null; //ponteiro
                if (dr.Read())
                {
                    user = new UsuarioDTO();
                    user.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    user.NomeUsuario = dr["NomeUsuario"].ToString();
                    user.EmailUsuario = dr["EmailUsuario"].ToString();
                    user.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    user.DtNascUsuario = Convert.ToDateTime(dr["DtNascUsuario"]);
                    user.UsuarioTp = dr["UsuarioTp"].ToString();
                }
                return user;
            }
            catch (Exception ex)
            {

                throw new Exception($"{msg} - {ex.Message}");
            }
            finally
            {
                Desconectar();
            }

        }

        //SearchByName
        public UsuarioDTO Search(string nomeUser)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Usuario WHERE NomeUsuario = @NomeUsuario;", conn);
                cmd.Parameters.AddWithValue("@NomeUsuario", nomeUser);
                dr = cmd.ExecuteReader();
                UsuarioDTO user = null; //ponteiro
                if (dr.Read())
                {
                    user = new UsuarioDTO();
                    user.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    user.NomeUsuario = dr["NomeUsuario"].ToString();
                    user.EmailUsuario = dr["EmailUsuario"].ToString();
                    user.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    user.DtNascUsuario = Convert.ToDateTime(dr["DtNascUsuario"]);
                    user.UsuarioTp = dr["UsuarioTp"].ToString();
                }
                return user;
            }
            catch (Exception ex)
            {

                throw new Exception($"{msg} - {ex.Message}");
            }
            finally
            {
                Desconectar();
            }

        }

        //LoadDDList
        public List<TipoUsuarioDTO> GetTypeUser()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM TipoUsuario;", conn);
                dr = cmd.ExecuteReader();
                List<TipoUsuarioDTO> listUser = new List<TipoUsuarioDTO>();//ponteiro
                while (dr.Read())
                {
                    TipoUsuarioDTO userTp = new TipoUsuarioDTO();
                    userTp.IdTipoUsuario = Convert.ToInt32(dr["IdTipoUsuario"]);
                    userTp.DescricaoTipoUsuario = dr["DescricaoTipoUsuario"].ToString();
                    listUser.Add(userTp);
                }
                return listUser;

            }
            catch (Exception ex)
            {
                throw new Exception($"{msg} - {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }
    }
}


