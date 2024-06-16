using System.Net.Mime;
using DemoMvc.Data;
using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoMvc.Controllers
{
    public class DailyController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DailyController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Daily.ToListAsync();
            return View(model); 
        }
        [HttpPost] 
        public async Task<IActionResult> Index(string KeySearch)
        {
            var model = await _context.Daily.Where(x => x.DiaChi.Contains(KeySearch)).ToListAsync();
            return View(model); 
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HeThongPhanPhoi,MaDaiLy,TenDaiLy,DiaChi,NguoiDaiDien,DienThoai,MaHTPP")] Daily daily)
        {
            if (ModelState.IsValid)
            {
                _context.Add(daily);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(daily);
        }
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Daily == null)
            {
                return NotFound();
            }
            var daily = await _context.Daily.FindAsync(id);
            if (daily == null)
            {
                return NotFound();
            } 
            return View(daily);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Edit(string id, [Bind("HeThongPhanPhoi,MaDaiLy,TenDaiLy,DiaChi,NguoiDaiDien,DienThoai,MaHTPP")] Daily daily)
        {
            if (id != daily.HeThongPhanPhoi)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(daily);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DailyExists(daily.HeThongPhanPhoi))
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
            return View(daily);  
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Daily == null)
            {
                return  NotFound();
            }
            var daily = await _context.Daily
                .FirstOrDefaultAsync(m => m.HeThongPhanPhoi == id);
            if (daily == null )
            {
                return NotFound();
            }
            return View(daily);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Daily == null)
            {
                return Problem("Entity set 'ApplicationDBContext.Daily' is null.");
            }
            var daily = await _context.Daily.FindAsync(id);
            if (daily != null)
            {
                _context.Daily.Remove(daily);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool DailyExists(string id)
        {
            return (_context.Daily?.Any(e => e.HeThongPhanPhoi ==id)).GetValueOrDefault();
        }
    }
}