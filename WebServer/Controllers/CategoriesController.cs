using System.Collections;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers;

[Route("api/categories")]
[ApiController]
public class CategoriesController : ControllerBase
{
    DataService ds = new DataService();
        
    [HttpGet]
    public IActionResult GetCategories()
    {
        return Ok(ds.GetCategories());
    }

    [HttpGet("{id}")]
    public IActionResult GetCategory(int id)
    {
        var category = ds.GetCategory((id));
        if (category == null)
        {
            return NotFound();
        }

        return Ok(category);
    }

    [HttpPost]
    public IActionResult CreateCategory(CreateCategoryModel model)
    {
        var category = new Category
        {
            Name = model.Name,
            Description = model.Description
        };
        
        ds.CreateCategory(category);
        return Ok(category);
    }
    
}