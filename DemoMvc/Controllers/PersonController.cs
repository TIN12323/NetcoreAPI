using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;
using DemoMvc.Data;
using Microsoft.EntityFrameworkCore;
using DemoMvc.Models.Process;
using OfficeOpenXml;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoMvc.Controllers;
public class PersonController : Controller
{
    private readonly ApplicationDbContext _context;
    private ExcelProcess _excelProcess = new ExcelProcess();
    public PersonController (ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index(int? page, int? PageSize)
    {
       ViewBag.PageSize = new List<SelectListItem>()
        {
            new SelectListItem() {Value="3",Text= "3"},
            new SelectListItem() {Value="5",Text= "5"},
            new SelectListItem() {Value="10",Text= "10"},
            new SelectListItem() {Value="20",Text= "20"},
            new SelectListItem() {Value="25",Text= "25"},
        };
        int pagesize = (PageSize ?? 3);
        ViewBag.psize = pagesize;
        var  model = _context.Person.ToList().ToPagedList(page ?? 1, pagesize);
        return View(model);
    }
    [HttpPost]
    public async Task<IActionResult> Index(string KeySearch)
    {
        if(_context.Person == null)
        {
            return Problem("Entity set 'ApplicationDbContext.Person' is null .");
        }
        var person = from m in _context.Person
                    select m;
        
        if(!string.IsNullOrEmpty(KeySearch))
        {
            person = person.Where(s => s.Fullname.Contains(KeySearch));
        }
        return View(await person.ToListAsync());
    }
    public IActionResult Create()
    {
        return  View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("PersonId,Fullname,Address,Workat")] Person person)
    {
        if (ModelState.IsValid)
        {
            _context.Add(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(person);
    }
    public async Task<IActionResult> Edit(string id)
    {
        if(id == null || _context.Person == null)
        {
            return NotFound();
        }
        var person = await _context.Person.FindAsync(id);
        if (person == null)
        {
            return NotFound();
        }
        return View(person);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id,[Bind("PersonId,Fullname,Address,Workat")]Person person)
    {
        if (id !=person.PersonId)
        {
            return NotFound();
        }
        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(person);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(person.PersonId))
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
        return View(person);
    }
    public async Task<IActionResult> Delete(string id)
    {
        if (id == null || _context.Person == null)
        {
            return NotFound();
        }
        var person = await _context.Person
.FirstOrDefaultAsync(m => m.PersonId == id);
            if (person == null )
            {
                return NotFound();
            }
            return View(person);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Person == null)
            {
                return Problem("Entity set 'ApplicationDBContext.Person' is null.");
            }
            var person = await _context.Person.FindAsync(id);
            if (person != null)
            {
                _context.Person.Remove(person);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Upload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Upload(IFormFile file)
        {
            if (file!=null)
            {
                string fileExtension = Path.GetExtension(file.FileName);
                if (fileExtension != ".xls" && fileExtension != ".xlsx")
                {
                    ModelState.AddModelError("", "please choose excel file to upload!");
                }
                else
                {
                    var personList =await  _context.Person.ToListAsync();
                   _context.RemoveRange(personList);
                   await _context.SaveChangesAsync();
                    //rename file when upload to server
                    var fileName = file.FileName;
                    var filePath = Path.Combine(Directory.GetCurrentDirectory()+ "/Upload/Excels", fileName);
                    var fileLocation = new FileInfo(filePath).ToString();
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        //save file to server
                        await file.CopyToAsync(stream);
                        //read data from excel fill DataTable
                        var dt = _excelProcess.ExcelToDataTable (fileLocation);
                        //using for loop to read data from dt
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            //create new Person object
                            var ps = new Person();
                            //set value to attributes
                            ps.PersonId = dt.Rows[i][0].ToString();
                            ps.Fullname = dt.Rows[i][1].ToString();
                            ps.Address = dt.Rows[i][2].ToString();
                            ps.Workat = dt.Rows[i][3].ToString();
                            //Add object to context
                            _context.Add(ps);    
                        }
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            return View();
        }
        public IActionResult Download()
        {
            //Name fill when dowloading
            var fileName = "fileTin" + ".xlsx";
            using(ExcelPackage excelPackage= new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Trang tinh 1");
                // add some text to cell A1
                worksheet.Cells["A1"].Value= "PersonId";
                worksheet.Cells["B1"].Value= "Fullname";
                worksheet.Cells["C1"].Value="Address";
                worksheet.Cells["D1"].Value="Workat";
                //get all PerSon
                var personList = _context.Person.ToList();
                //fill data to worksheet
                worksheet.Cells["A3"].LoadFromCollection(personList);
                var stream = new MemoryStream(excelPackage.GetAsByteArray());
                //download file
                return File(stream,"application/vnd-ms-excel",fileName);

            } 
        }
        private bool PersonExists(string id)
        {
            return (_context.Person?.Any(e => e.PersonId ==id)).GetValueOrDefault();
        }
    }