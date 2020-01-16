using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Levins.My.WebApi.Data
{
    public class LevinsDbContext : IdentityDbContext
    {
        public LevinsDbContext(DbContextOptions<LevinsDbContext> options)
            : base(options)
        {
        }
    }
}
