using Microsoft.AspNetCore.Mvc;
using WebApplicationCar.Data;
using WebApplicationCar.Models.Cars.Toyota;

namespace WebApplicationCar.Controllers.HandMade;

public class ColorsHandMadeController : Controller

{
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(
        [Bind("Name", "RGB", "Code")] ColorModel colorModel, IFormFile file
    )
    {
        string baseUrl = "/storage/colors";
        
        if (file != null && file.Length > 0)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), 
                "wwwroot" + baseUrl, file.FileName);

            using ( var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            
            colorModel.Url = baseUrl + "/" + file.FileName; 
        }

        
        
        if (ModelState.IsValid)
        {
            _context.Add(colorModel);
            await _context.SaveChangesAsync();
        }
        
        return RedirectToAction(nameof(Create));
    }
    
    private readonly ApplicationDbContext _context;

    public ColorsHandMadeController (ApplicationDbContext context)
    {
        _context = context;
    }
        

}