using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NovaApiTraining.Data;
using NovaApiTraining.DTOs;
using NovaApiTraining.ViewModels;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace NovaApiTraining.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IConfiguration _config;

        private readonly AppDBcontext _context;

        private readonly ILogger<DataFetcher> _logger;
        public AccountsController(ILogger<DataFetcher> logger, AppDBcontext context, IConfiguration config)
        {
            _context = context;
            _config = config;
            _logger = logger;
        }

        // GET: Accounts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Account.ToListAsync());
        }

        // GET: Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .FirstOrDefaultAsync(m => m.id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Accounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserName,Password")] Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserName,Password")] Account account)
        {
            if (id != account.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.id))
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
            return View(account);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .FirstOrDefaultAsync(m => m.id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _context.Account.FindAsync(id);
            if (account != null)
            {
                _context.Account.Remove(account);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return _context.Account.Any(e => e.id == id);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("Login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM objUser)
        {
            if (!ModelState.IsValid)
            {
                return View(objUser);
            }

            if (string.IsNullOrWhiteSpace(objUser.UserName) || string.IsNullOrWhiteSpace(objUser.Password))
            {
                TempData["Message"] = "Username and password are required.";
                return View(objUser);
            }

            var user = await _context.Account.FirstOrDefaultAsync(u => u.UserName == objUser.UserName);
            if (user == null)
            {
                TempData["Message"] = "No account found with the given username.";
                return View(objUser);
            }

            // For demonstration purposes, assume passwords are stored in plain text (not recommended)
            if (objUser.Password != user.Password)
            {
                TempData["Message"] = "Incorrect password.";
                return View(objUser);
            }

            //If login usrename and password are correct then proceed to generate token
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtSettings:key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var Sectoken = new JwtSecurityToken(_config["JwtSettings:Issuer"],
              _config["JwtSettings:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            var token = new JwtSecurityTokenHandler().WriteToken(Sectoken);

            _logger.LogInformation(token);

            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}


