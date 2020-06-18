using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseForRent.Data.Entities
{
    public class AppUser: IdentityUser<Guid>
    {
        public string Name { get; set; }
    }
}
