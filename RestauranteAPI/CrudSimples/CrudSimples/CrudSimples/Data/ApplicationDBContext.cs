using Microsoft.EntityFrameworkCore;

namespace CrudSimples.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : identityDbContext
{
}


