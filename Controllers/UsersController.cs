using BarberShopp.DataBase;
using BarberShopp.Entities;
using BarberShopp.Service_Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barbershopp.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _service;
        private readonly DataBaseContext _context;

        public UsersController(IUserService service,DataBaseContext context)
        {
            _service = service; 
            _context = context;
        }
        public async Task<IActionResult> Login([Bind("UserName,Password")] UserEntity userEntity) {
            if (_service.CheckUser(userEntity.UserName,userEntity.Password))
            {
                return RedirectToAction("Home", "Pages");
                
            }
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> LoginView()
        { 
            return View("Views/Users/Login.cshtml");
        }
        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var userEntity = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userEntity == null)
            {
                return NotFound();
            }

            return View(userEntity);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }
         // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,FirstName,LastName,Password,Email")] UserEntity userEntity)
        {
            if (ModelState.IsValid)
            {
               await _service.AddUser(userEntity);
               return RedirectToAction("Home","Pages");
            }
            return View(userEntity);
        }
         
        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var userEntity = await _context.Users.FindAsync(id);
            if (userEntity == null)
            {
                return NotFound();
            }
            return View(userEntity);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Id,UserName,FirstName,LastName,Password,Email")] UserEntity userEntity)
        {
            if (id != userEntity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _service.UpdateUser(userEntity);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserEntityExists(userEntity.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userEntity);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var userEntity = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userEntity == null)
            {
                return NotFound();
            }

            return View(userEntity);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.Users == null)
            {
                return Problem("Entity set 'DataBaseContext.Users'  is null.");
            }
            var userEntity = await _context.Users.FindAsync(id);
            if (userEntity != null)
            {
                await _service.DeleteUser(userEntity);
            }


            return RedirectToAction(nameof(Index));
        }

        private bool UserEntityExists(int? id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
        
    }
}
