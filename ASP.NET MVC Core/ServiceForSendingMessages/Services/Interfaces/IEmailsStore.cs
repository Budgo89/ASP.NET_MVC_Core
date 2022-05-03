using ServiceForSendingMessages.Models;

namespace ServiceForSendingMessages.Services.Interfaces;

public interface IEmailsStore
{
    IEnumerable<Mails> GetAll();
    Mails? GetById(int id);
    int Add(Mails item);
    bool Edit(Mails item);
    bool Remove(int id);
}
