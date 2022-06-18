using BlazorLibrary.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLibrary.Domain.Enities
{
    public class User : AuditableEntity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
    }
}
