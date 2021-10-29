using System.Threading.Tasks;

namespace NotificationSystem.Services.Mail.Interface
{
    public interface IMessageService
    {
        Task<bool> SendMessage(int languageId);
        void ReceiveMessage();
    }
}