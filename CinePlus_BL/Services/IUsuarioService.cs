using CinePlus_BL.Dtos;
using CinePlus_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinePlus_BL.Services
{
    public interface IUsuarioService
    {
        public IEnumerable<Usuario> GetUsuarios();
        public Usuario GetUsuario(int id);
        public void SaveUsuario(UsuarioDto usuarioDto);
        public void UpdateUsuario(UsuarioDto usuarioDto, int id);
        public void DeleteUsuario(int id);
    }
}
