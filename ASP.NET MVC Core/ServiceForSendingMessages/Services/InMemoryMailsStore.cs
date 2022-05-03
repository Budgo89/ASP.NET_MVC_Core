using ServiceForSendingMessages.Models;
using ServiceForSendingMessages.Services.Interfaces;

namespace ServiceForSendingMessages.Services;
public class InMemoryMailsStore : IEmailsStore
{
    private readonly List<Mails> _mails;
    private readonly ILogger<InMemoryMailsStore> _logger;
    private int _maxFreeId;

    public InMemoryMailsStore(ILogger<InMemoryMailsStore> logger)
    {
        _logger = logger;
        _mails = new List<Mails>();
        _mails.Add(new Mails
        {
            Id = 1,
            Email = "Budgo@mail.ru"
        });
        _maxFreeId = _mails.Max(e => e.Id) + 1;
    }

    public IEnumerable<Mails> GetAll() => _mails;

    public Mails? GetById(int id) => _mails.FirstOrDefault(x => x.Id == id);

    public int Add(Mails item)
    {
        item.Id = _maxFreeId;
        _maxFreeId++;
        _mails.Add(item);
        return item.Id;
    }

    public bool Edit(Mails item)
    {
        var bdItem = GetById(item.Id);
        if (bdItem is null)
        {
            return false;
        }
        bdItem.Email = item.Email;
        return true;
    }

    public bool Remove(int id)
    {
        var bdItem = GetById(id);
        if (bdItem is null)
        {
            return false;
        }
        _mails.Remove(bdItem);
        return true;
    }
}
