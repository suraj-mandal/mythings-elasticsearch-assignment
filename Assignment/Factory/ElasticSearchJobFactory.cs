using Quartz;
using Quartz.Spi;

namespace Assignment.Factory;

public class ElasticSearchJobFactory(IServiceProvider serviceProvider) : IJobFactory
{
    public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
    {
        var scope = serviceProvider.CreateScope();
        return (scope.ServiceProvider.GetRequiredService(bundle.JobDetail.JobType) as IJob)!;
    }

    public void ReturnJob(IJob job)
    {
        (job as IDisposable)?.Dispose();
    }
}