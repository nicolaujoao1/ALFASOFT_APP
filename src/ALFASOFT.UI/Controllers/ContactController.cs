using ALFASOFT.Application.DTOs;
using ALFASOFT.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ALFASOFT.UI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<IActionResult> Index()
        {
            var entity = await _contactService.GetAllAsync();
            return View(entity);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ContactDTO contactDTO)
        {
            if (!ModelState.IsValid) return View();
            else
            {
                var isCreated = await _contactService.CreateAsync(contactDTO);
                return isCreated ? RedirectToAction(nameof(Index)) : View();
            }
        }
    }
}
