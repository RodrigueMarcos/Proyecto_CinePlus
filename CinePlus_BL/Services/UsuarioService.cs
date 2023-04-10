using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinePlus_BL.Dtos;
using CinePlus_DAL;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly CinePlusContext _context;
        public UsuarioService(CinePlusContext context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario GetUsuario(int id)
        {
            return _context.Usuarios.FirstOrDefault(usuario => usuario.ID == id);
        }

        public void SaveUsuario(UsuarioDto usuarioDto)
        {
            var usuario = new Usuario()
            {
                role = usuarioDto.role,
                name = usuarioDto.name,
                lastName = usuarioDto.lastName,
                createdAt = usuarioDto.createdAt,
                userName = usuarioDto.userName,
            };

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void UpdateUsuario(UsuarioDto usuarioDto, int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.ID == id);

            if (usuario == null)
            {
                throw new ArgumentException("Usuario not found.");
            }

            usuario.role = usuarioDto.role;
            usuario.name = usuarioDto.name;
            usuario.lastName = usuarioDto.lastName;
            usuario.modifiedAt = usuarioDto.modifiedAt;
            usuario.modifiedBy = usuarioDto.modifiedByID;
            usuario.userName = usuarioDto.userName;

            _context.SaveChanges();
        }

        public void DeleteUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario == null)
            {
                throw new ArgumentException("Usuario does not exist");
            }
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }
    }
}