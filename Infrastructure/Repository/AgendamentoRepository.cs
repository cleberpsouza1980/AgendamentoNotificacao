using Domain.Data.Interfaces;
using Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repository
{
    public class AgendamentoRepository : IAgendamentoRepsoitory
    {
        private readonly IConfiguration _configuration;
        public AgendamentoRepository(IConfiguration configuration) 
        {
            _configuration = configuration;
        }
        public AgendamentoNotificacaoDTO GravarAgenda(AgendamentoNotificacaoDTO agendamentoNotificacao)
        {
            using (AppDbContext db = new AppDbContext(_configuration))
            {
                db.Add(agendamentoNotificacao);
                return agendamentoNotificacao;
            }
        }
    }
}
