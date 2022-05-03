using Microsoft.AspNetCore.Mvc;
using ServiceForSendingMessages.Models;
using ServiceForSendingMessages.Services.Interfaces;
using ServiceForSendingMessages.ViewModels;

namespace ServiceForSendingMessages.Controllers;
public class EmailController : Controller
{
    private readonly ILogger<EmailController> _logger;
    private readonly IEmailsStore _emailsStore;

    public EmailController(IEmailsStore emailsStore, ILogger<EmailController> logger)
    {
        _emailsStore = emailsStore;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var emailsStore = _emailsStore.GetAll();

        return View(emailsStore);
    }

    public IActionResult Details( int id)
    {
        var email = _emailsStore.GetById(id);
        if (email == null)
        {
            return NotFound();
        }

        return View(new MailsViewModels
        {
            Email = email.Email,
        });
    }

    public IActionResult Create() => View("Edit", new MailsViewModels());
    public IActionResult Edit( int id)
    {
        var email = _emailsStore.GetById(id);
        if (email == null)
        {
            return NotFound();
        }
        

        return View(new MailsViewModels
        {
            Email = email.Email,
        });
    }
    [HttpPost]
    public IActionResult Edit(MailsViewModels models)
    {
        var email = new Mails
        {
            Id = models.Id,
            Email = models.Email,
        };

        if (email.Id == 0)
        {
            var id = _emailsStore.Add(email);
            return RedirectToAction("Delete", new { id });
        }

        var editResult = _emailsStore.Edit(email);
        if (!editResult)
        {
            return NotFound();
        }

        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var email = _emailsStore.GetById(id);
        if (email == null)
        {
            return NotFound();
        }
        return View(new MailsViewModels
        {
            Id = email.Id,
            Email = email.Email,
        });
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        var email = _emailsStore.GetById(id);
        if (email == null)
        {
            return NotFound();
        }
        return RedirectToAction("Index");
    }
}
