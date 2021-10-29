using System.Threading.Tasks;

namespace NotificationSystem.Services.Message.Interface
{
    public interface IMessageService
    {
        Task<bool> SendMessage(int languageId);
        void ReceiveMessage();
    }
}