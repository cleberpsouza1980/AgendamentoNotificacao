using Domain.CommandHandler;
using Domain.Data.Interfaces;
using Domain.Interfaces;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting
{
    public class InjectionDependicy
    {
        public static void Inicialize(IServiceCollection serviceCollection)
        {

            serviceCollection.AddScoped<IAgendamentoNotificationHandler, AgendamentoNotificacaoHandler>();
            serviceCollection.AddScoped<IAgendamentoRepsoitory, AgendamentoRepository>();
        }
    }
}
