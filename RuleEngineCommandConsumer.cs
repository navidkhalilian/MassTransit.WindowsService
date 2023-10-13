using System.Threading;
using System.Threading.Tasks;

namespace MassTransit.WindowsService
{
    public class RuleEngineCommandConsumer : IConsumer<SampleDto>
    {
        public Task Consume(ConsumeContext<SampleDto> context)
        {
            Thread.Sleep(context.Message.SampleInput);
            return Task.CompletedTask;
        }
    }
}