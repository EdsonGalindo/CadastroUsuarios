using CadastroUsuarios.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroUsuarios.Dao
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options)
            : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
