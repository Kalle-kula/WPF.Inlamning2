using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Wpf.InlamningsUppgift2
{
    public class ApplicantContext : DbContext
    {
        public DbSet<Applicant>Applicants { get; set; }
    }
}
