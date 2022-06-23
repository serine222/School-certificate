using corecrud.Models;
using corecrud;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corecrud.Controllers
{
    public class StudentsController : Controller
    {
        private readonly Context _context;

        public StudentsController(Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
           
              return View(await _context.Students.ToListAsync()) ;
            
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> UpdateStudent(int id)
        {
            Student student = await _context.Students.FindAsync(id);
            return View(student);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            Student student = await _context.Students.FindAsync(id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> ReadeStudent(int id)
        {
            Student student = await _context.Students.FindAsync(id);
            return View(student);
        }
    }
}
