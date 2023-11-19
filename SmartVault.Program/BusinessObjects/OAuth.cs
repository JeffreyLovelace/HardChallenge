using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVault.Program.BusinessObjects
{
    public class OAuth
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Token { get; set; }
        public string Expiration { get; set; }
    }
}
