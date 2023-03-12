using MediatorDesignPattern_NET.Models;

namespace MediatorDesignPattern_NET.Repositories
{
    public interface INotificationService
    {
        void SendNotification(Product product);
    }
}
