using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentPL.Models;

namespace StudentPL.Data
{
    public class StudentPLContext : DbContext
    {
        public StudentPLContext (DbContextOptions<StudentPLContext> options)
            : base(options)
        {
        }

        public DbSet<StudentPL.Models.Student> Student { get; set; } = default!;
    }
}
