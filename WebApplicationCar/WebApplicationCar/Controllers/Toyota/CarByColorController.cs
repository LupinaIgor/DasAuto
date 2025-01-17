﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationCar.Data;

namespace WebApplicationCar.Controllers.Toyota;

public class CarByColorController : Controller
{
    private readonly ApplicationDbContext _context;

    public CarByColorController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(
        int? modelId,
        int? ConfigurationId = null,
        int? ColorId = null
        )
    {
        var modelList = _context.ToyotaModels.ToList();
        ViewBag.models = new SelectList(modelList, "Id", "Name", modelId);
        
        if (modelId != null)

        { 
            var configurationList = _context.Configurations
            .Where(c => c.ModelId == modelId).ToList();
        
            ViewBag.configurations = new SelectList(configurationList, 
                "Id", "Name", ConfigurationId);
            
        }
        
        if (ConfigurationId != null)
        {

            var colorList = _context.ConfigurationColors
                .Include(c => c.Color)
                .Where(c => c.ConfigurationId == ConfigurationId)
                .ToList();
            ViewBag.colors = new SelectList(colorList, "Id", "Color.Name", ColorId);
        }

        if (ColorId != null)
        {
            var photo = _context.ConfigurationColors
                .Where(c => c.ConfigurationId == ConfigurationId)
                .FirstOrDefault(c => c.ColorId == ColorId);

            ViewBag.photo = photo;
        }
       

        return View();
    }
}