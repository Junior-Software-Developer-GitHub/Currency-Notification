using System;
using Data.Models.User;
using NotificationSystem.Services.Message.Interface;
using NotificationSystem.Services.Scheduler.Interface;

namespace NotificationSystem.Services.Scheduler
{
    public class SchedulerService : ISchedulerService
    {
        public void Schedule(IMessageService messageService)
        {
            TimeSpan timeSpan = new TimeSpan(0, 15, 35, 0);
            
            if (DateTime.Now.Hour == timeSpan.Hours && DateTime.Now.Minute == timeSpan.Minutes && DateTime.Now.Second == timeSpan.Seconds)
            {
                User user = User.Instance;
                messageService.SendMessage(user.LanguageId);
                messageService.ReceiveMessage();
            }
        }
    }
}