using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]

public class DriverControllers : ControllerBase
{
    private readonly ILogger<DriverControllers> _logger;
    private readonly ApiDbContext _context;

    public DriverControllers(ILogger<DriverControllers> logger, ApiDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetAllDrivers")]
    public async Task<IActionResult> Get()
    {
        var driver = new Driver()
        {
            DriverNumber = 32,
            Name = "Sir Louis Phelip"
        };

        _context.Add(driver);
        await _context.SaveChangesAsync();

        var allDrivers = await _context.Drivers.ToListAsync();

        return Ok(allDrivers);
    }
}