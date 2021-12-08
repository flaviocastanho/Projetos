using EFCore.Dominio;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Repo
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options) {}

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Cliente_Endereco> Cliente_Enderecos { get; set; }

    }
}
