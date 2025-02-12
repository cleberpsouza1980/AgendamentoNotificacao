using Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repository
{
    public class AppDbContext : DbContext
    {
        //const string ConnectionString = "Host=transfersql.luftfarma.com.br;Username=user_luft_informa;Password=farma_intec#202102081654;Database=farma_intec_hmlg_db";
        private readonly IConfiguration _configuration;
        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<AgendamentoNotificacaoDTO> AgendamentoNoticacao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
    }
}
