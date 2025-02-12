using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.Interfaces
{
    public interface IAgendamentoRepsoitory
    {
        AgendamentoNotificacaoDTO GravarAgenda(AgendamentoNotificacaoDTO agendamentoNotificacao);
    }
}
