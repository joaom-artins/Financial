using Microsoft.EntityFrameworkCore;

namespace FInancial.Infra.Persistence.Context;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
}
