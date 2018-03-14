using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runn.DataModel
{
    public class RunnerAccount
    {
        public int RunnerAccountId { get; set; }
        public Runner Runner { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string OathToken { get; set; }
    }
}
