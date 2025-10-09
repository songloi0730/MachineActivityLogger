using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineActivityLogger.src.Models
{
    public class User
    {
        public string Username { get; set; }
        public string UserLevel { get; set; }
        public bool IsAuthenticated { get; set; }
        public DateTime LoginTime { get; set; }
    }
}
