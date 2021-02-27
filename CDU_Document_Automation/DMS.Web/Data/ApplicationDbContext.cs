using System;
using System.Collections.Generic;
using System.Text;
using DMS.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DMS.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UserModel> UserList { get; set; }
        public DbSet<UnitInformationModel> UnitInformationList { get; set; }
        public DbSet<UnitDescriptionModel> UnitDescriptionList { get; set; }
    }
}
