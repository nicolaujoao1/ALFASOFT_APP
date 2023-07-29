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
        [HttpGet()]
        public async Task<IActionResult> Delete(Guid Id)
        {
            var entity = await _contactService.GetByIdAsync(Id);
            return entity is null ? NotFound() : View(entity);
        }
        [HttpPost(), ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid Id)
        {
            await _contactService.DeleteAsync(Id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid Id)
        {
            var entity = await _contactService.GetByIdAsync(Id);

            return entity is null ? NotFound() : View(entity);
        }
        [HttpGet]
        public async Task<IActionResult> Preview(Guid Id)
        {
            var entity = await _contactService.GetByIdAsync(Id);

            return entity is null ? NotFound() : View(entity);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ContactDTO contactDTO)
        {
            if (!ModelState.IsValid) return View();

            var isCreated = await _contactService.UpdateAsync(contactDTO);
            return isCreated ? RedirectToAction(nameof(Index)) : View();

        }
    }
}
