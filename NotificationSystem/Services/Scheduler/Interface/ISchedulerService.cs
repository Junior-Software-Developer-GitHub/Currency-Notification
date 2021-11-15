using NotificationSystem.Services.Message.Interface;

namespace NotificationSystem.Services.Scheduler.Interface
{
    public interface ISchedulerService
    {
        void Schedule(IMessageService messageService);
    }
}