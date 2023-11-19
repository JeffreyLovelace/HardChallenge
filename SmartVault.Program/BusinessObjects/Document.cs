using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartVault.Program.BusinessObjects
{
    public partial class Document
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
