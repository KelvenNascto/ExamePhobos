using EnxamePhobos.DAL;
using EnxamePhobos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnxamePhobos.BLL
{
    public class UsuarioBLL
    {
        UsuarioDTO userDTO = new UsuarioDTO();
        UsuarioDAL userDAL = new UsuarioDAL();

        public UsuarioDTO AuthenticateUserBLL(string user, string password)
        {
            return userDAL.AuthenticateUser(user, password);
        }

        public void CreateUserBLL(UsuarioDTO user)
        {
            userDAL.CreateUser(user);
        }

        public List<UsuarioDTO> GetUserBLL()
        {
            return userDAL.GetUser();
        }
        public void UpdateUserBLL(UsuarioDTO user)
        {
            userDAL.UpdateUser(user);
        }
        public void DeleteUser(int IdUser)
        {
            userDAL.DeleteUser(IdUser);
        }

        //SearchById
        public UsuarioDTO SearchBLL(int idUser)
        {
            return userDAL.Search(idUser);
        }

        //SearchByName
        public UsuarioDTO SearchBLL(string nomeUser)
        {
            return userDAL.Search(nomeUser);
        }

        public List<TipoUsuarioDTO> GetTypeUserBLL()
        {
            return userDAL.GetTypeUser();
        }
    }

}

