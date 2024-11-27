using JKLHealthcareSystem.Data;
using JKLHealthcareSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JKLHealthcareSystem.Controllers
{
    public class AssignmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AssignmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Assignment
        public async Task<IActionResult> Index()
        {
            return View(await _context.Assignments.Include(a => a.Patient).Include(a => a.Caregiver).ToListAsync());
        }
    }
}
