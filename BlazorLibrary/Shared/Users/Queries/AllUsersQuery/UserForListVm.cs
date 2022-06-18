using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLibrary.Shared.Users.Queries.AllUsersQuery
{
    public class UserForListVm
    {
       // need to add list of writers and types
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public DateTime? CreateDate { get; set; }
        public int StatusId { get; set; }
        public int Id { get; set; }
    }
}
