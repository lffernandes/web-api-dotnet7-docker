
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext>options)
        : base(options)
    {

    }

    public DbSet<Driver> Drivers {get; set;}
}