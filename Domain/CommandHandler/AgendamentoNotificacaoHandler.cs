using Domain.Data.Interfaces;
using Domain.DTO;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CommandHandler
{
    public class AgendamentoNotificacaoHandler:IAgendamentoNotificationHandler
    {
        IAgendamentoRepsoitory _AgendamentoRepository;

        public AgendamentoNotificacaoHandler(IAgendamentoRepsoitory agendamentoRepsoitory)
        {
            _AgendamentoRepository = agendamentoRepsoitory;
        }

        public AgendamentoNotificacaoDTO AgendamentoNotificacao(AgendamentoNotificacaoDTO agendamentoNotificacao)
        {
            return _AgendamentoRepository.GravarAgenda(agendamentoNotificacao);
        }
    }
}
