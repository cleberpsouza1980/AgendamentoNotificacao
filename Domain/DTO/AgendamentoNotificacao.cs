using Domain.Enums;
using System;

namespace Domain.DTO
{
    public class AgendamentoNotificacaoDTO
    {
        public int? Id { get; set; }
        public DateTime Data_Agenda { get; set; }
        public string Telefone_Agenda { get; set; }
        public string Email_Agenda { get; set; }
        public EmunsAgenda Status_Agenda { get; set; }
    }
}
