using Microsoft.Extensions.Logging;

namespace backgroundService
{

    public class BackgroundWorkerService : BackgroundService
    {
        private readonly ILogger<BackgroundService> _logger;

        public BackgroundWorkerService(ILogger<BackgroundService> logger)
        {
            _logger = logger;
        }
        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Background Service Started");
                await Task.Delay(1000 ,stoppingToken);
            }

        }
    }


}
