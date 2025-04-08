using ArksoftPractical_MarcoMeyer.Data;
using ArksoftPractical_MarcoMeyer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArksoftPractical_MarcoMeyer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _db;
        private const int PageSize = 10;

        public CustomerController(AppDbContext db)
        {
            _db = db;
        }

       
        public async Task<IActionResult> Index(
            string? filterName,
            string? filterVat,
            string sortField = "Name", //default sorting field
            bool sortAsc = true,
            int page = 1) //default page number 1
        {
            var query = _db.Customers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filterName))
                query = query.Where(c => EF.Functions.Like(c.Name, $"%{filterName}%"));

            if (!string.IsNullOrWhiteSpace(filterVat))
                query = query.Where(c => EF.Functions.Like(c.VatNumber, $"%{filterVat}%"));
            
            //applies sorting logic
            query = (sortField, sortAsc) switch
            {
                ("Name", true) => query.OrderBy(c => c.Name),
                ("Name", false) => query.OrderByDescending(c => c.Name),
                ("Vat", true) => query.OrderBy(c => c.VatNumber),
                ("Vat", false) => query.OrderByDescending(c => c.VatNumber),
                _ => query.OrderBy(c => c.Name)
            };

            //calculate total pages needed based on number of customers
            var total = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(total / (double)PageSize);

            //retrieve customers for current page
            var items = await query
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();

            var vm = new CustomerListViewModel
            {
                Customers = items,
                FilterName = filterName,
                FilterVat = filterVat,
                SortField = sortField,
                SortAsc = sortAsc,
                Page = page,
                TotalPages = totalPages
            };

            return View(vm);
        }

       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return View(new Customer());
            var customer = await _db.Customers.FindAsync(id.Value);
            return customer == null ? NotFound() : View(customer);
        }

     
        [HttpPost]
        public async Task<IActionResult> Edit(Customer model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (model.Id == 0)
                _db.Customers.Add(model);
            else
                _db.Customers.Update(model);

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

     
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var customer = await _db.Customers.FindAsync(id);
            if (customer != null)
            {
                _db.Customers.Remove(customer);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
