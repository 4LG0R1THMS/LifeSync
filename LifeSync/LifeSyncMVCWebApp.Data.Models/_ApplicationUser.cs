using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LifeSyncMVCWebApp.Data.Models
{
    public class _ApplicationUser : IdentityUser<Guid>
    {
        public _ApplicationUser()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
