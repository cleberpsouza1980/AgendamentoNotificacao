using Domain.DTO;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgendamentoNotificacao.Controllers
{
    public class AgendamentoController : Controller
    {
        private readonly IAgendamentoNotificationHandler _AgendamentoHandler;
        public AgendamentoController(IAgendamentoNotificationHandler AgendaHandler)
        {
            _AgendamentoHandler = AgendaHandler;
        }
        [HttpPost]
        public IActionResult GravarAgendamento([FromBody] AgendamentoNotificacaoDTO agendamento)
        {
            if (agendamento == null)
            {
                agendamento = new AgendamentoNotificacaoDTO()
                {
                    Data_Agenda = System.DateTime.Now,
                    Telefone_Agenda = "(11)98111-9797",
                    Email_Agenda = "teste@Teste.com.br",
                    Status_Agenda = Domain.Enums.EmunsAgenda.Agendado,
                };
            }

            return Ok(_AgendamentoHandler.AgendamentoNotificacao(agendamento));
        }

        public IActionResult Index()
        {
            return Ok();
        }
    }
}
