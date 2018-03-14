using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Runn.DataModel;

namespace Runn.DataAccess
{
    public class RunnerRepository
    {
        public DbSet<Runner> Runners { get; set; }
    }
}
