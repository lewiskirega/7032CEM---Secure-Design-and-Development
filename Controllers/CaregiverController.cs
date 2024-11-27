using JKLHealthcareSystem.Data;
using JKLHealthcareSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JKLHealthcareSystem.Controllers
{
    public class CaregiverController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CaregiverController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Caregiver
        public async Task<IActionResult> Index()
        {
            return View(await _context.Caregivers.ToListAsync());
        }

        // GET: Caregiver/Assign
        public IActionResult Assign()
        {
            return View();
        }

        // POST: Caregiver/Assign
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Assign(int patientId, int caregiverId)
        {
            var assignment = new Assignment
            {
                PatientId = patientId,
                CaregiverId = caregiverId,
                AssignmentDate = DateTime.Now
            };
            _context.Add(assignment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
