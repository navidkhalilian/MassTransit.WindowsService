using Microsoft.Extensions.Configuration;

namespace MassTransit.WindowsService
{
    public static class XRabbitMqConfig
    {
        public static RabbitMqConfig RabbitMqConfig(this IConfiguration configuration)
            => configuration.GetSection(nameof(WindowsService.RabbitMqConfig))?.Get<RabbitMqConfig>() ??
               new RabbitMqConfig();
    }

    /// <summary> Configuration Key and Container for appSettings.json </summary>
    public class RabbitMqConfig
    {
        /// <summary> RabbitMq Server Name or IP-Address </summary>
        public string? Host { get; set; } = "";

        /// <summary> Default virtual Host (to partition Messages) </summary>
        public string? Path { get; set; } = "";

        /// <summary> Username (Default works only for localhost) </summary>
        public string? UserName { get; set; } = "";

        /// <summary> Password (Default works only for localhost) </summary>
        public string? PassWord { get; set; } = "";
    }
}