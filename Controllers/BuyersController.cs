using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Property_Sales_Final_Project.Models;

namespace Property_Sales_Final_Project.Controllers
{
    //Buyers controller.
    [Authorize(Roles= "properyAdmin")]
    public class BuyersController : Controller
    {
        private readonly Property_Sales_DatabaseContext _context;

        public BuyersController(Property_Sales_DatabaseContext context)
        {
            _context = context;
        }

        // GET: Buyers
        //Gets all buyers 
        public async Task<IActionResult> Index()
        {
            return View(await (from buyers in _context.Buyer
                               select buyers
                               
                               ).ToListAsync());
        }

        // GET: Buyers/Details/5
        //Get buyer details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyer = await _context.Buyer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (buyer == null)
            {
                return NotFound();
            }

            return View(buyer);
        }

     
        //Get buyer for delete

        // GET: Buyers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyer = await _context.Buyer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (buyer == null)
            {
                return NotFound();
            }

            return View(buyer);
        }

        // POST: Buyers/Delete/5
        //Deletes the buyer.
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var buyer = await _context.Buyer.FindAsync(id);
            _context.Buyer.Remove(buyer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
