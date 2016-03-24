using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Security
{
    public static class AppRoleExtensions
    {
        public static string[] ToStringArray(this AppRole[] appRoles)
        {
            List<string> intList = new List<string>();
            foreach (var appRole in appRoles)
            {
                intList.Add(appRole.ToString());
            }
            return intList.ToArray<string>();
        }
    }
}
