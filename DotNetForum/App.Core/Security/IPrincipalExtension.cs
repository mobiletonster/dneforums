using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Security
{
    public static class IPrincipalExtension
    {
        public static bool HasAnyRole(this IPrincipal user, params AppRole[] roles)
        {
            var roleArray = roles.ToStringArray();
            var result = roleArray.Any(user.IsInRole);
            return result;
        }

        public static string GetEmail(this IPrincipal user)
        {
            var claimsUser = user as ClaimsPrincipal;
            var email = claimsUser.FindFirst(ClaimTypes.Email).Value;
            return email;
        }
    }
}
