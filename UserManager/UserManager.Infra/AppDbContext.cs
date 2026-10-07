using Microsoft.EntityFrameworkCore;

namespace UserManager.Infra
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {

    }
}
