using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Property_Sales_Final_Project.Models;


using Microsoft.AspNetCore.Identity;



namespace Property_Sales_Final_Project.Controllers
{
    
    //Sales transaction controller.
    public class SalesTransactionsController : Controller
    {
        private readonly Property_Sales_DatabaseContext _context;

       SignInManager<IdentityUser> SignInManager;

        UserManager<IdentityUser> UserManager;

        public SalesTransactionsController(
            Property_Sales_DatabaseContext context,
             SignInManager<IdentityUser> _SignInManager,
             UserManager<IdentityUser> _UserManager

            )
        {
            SignInManager = _SignInManager;
            UserManager = _UserManager;
            _context = context;
        }

        // GET: SalesTransactions
        //Get all sales transaction using  a lamda query.
        [Authorize(Roles = "properyAdmin")]
        public async Task<IActionResult> Index()
        {
            var property_Sales_DatabaseContext = _context.SalesTransaction.Include(s => s.Buyer).Include(s => s.Property);
            return View(await property_Sales_DatabaseContext.ToListAsync());
        }

        // GET: SalesTransactions/Details/5
        //Get details of the sales transactions.
        [Authorize(Roles = "properyAdmin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesTransaction = await _context.SalesTransaction
                .Include(s => s.Buyer)
                .Include(s => s.Property)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesTransaction == null)
            {
                return NotFound();
            }

            return View(salesTransaction);
        }

        // GET: SalesTransactions/Create
        //Creates a sales transaction buyer only 
        [Authorize(Roles = "buyer")]
        public IActionResult Create(int id)
        {
            SalesTransaction transAction = new SalesTransaction();

            if (SignInManager.IsSignedIn(User)) {


                var buyer = (from buyers in _context.Buyer
                             where buyers.Name.Equals(User.Identity.Name)
                             select buyers).FirstOrDefault();

            
                transAction.BuyerId = buyer.Id;
                transAction.PropertyId = id;

                _context.SalesTransaction.Add(transAction);
                _context.SaveChanges();

                _context.SalesTransaction.Include(s => s.Buyer)
                    .Include(s => s.Property).FirstOrDefault(s => s.Id == transAction.Id);
               
            
            }


            
            return View(transAction);
        }


        //Gets the transaction for delete
        // GET: SalesTransactions/Delete/5
        [Authorize(Roles = "properyAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesTransaction = await _context.SalesTransaction
                .Include(s => s.Buyer)
                .Include(s => s.Property)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesTransaction == null)
            {
                return NotFound();
            }

            return View(salesTransaction);
        }

        // POST: SalesTransactions/Delete/5
        //Deletes the transaction
        [Authorize(Roles = "properyAdmin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salesTransaction = await _context.SalesTransaction.FindAsync(id);
            _context.SalesTransaction.Remove(salesTransaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
