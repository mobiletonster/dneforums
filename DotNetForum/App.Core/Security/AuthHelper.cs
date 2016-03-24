using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Security
{
    public static class AuthHelper
    {
        public static bool CheckCredentials(string rawCredentials)
        {
            try
            {
                var encoding = Encoding.GetEncoding("iso-8859-1");
                var credentials = encoding.GetString(Convert.FromBase64String(rawCredentials));  // mobiletony@msn.com|1|1854|7/25/2014 11:06:50 PM
                var split = credentials.Split('|');
                var username = split[0];
                var uid = split[1];
                var secretNumber = split[2];
                var expires = split[3];

                var userId = Convert.ToInt32(uid);
                var checkSecretNumber = SecretNumber(username, userId);
                if (secretNumber != checkSecretNumber)
                {
                    return false;
                }
                var expirationDate = Convert.ToDateTime(expires);
                if (DateTime.Now > expirationDate) {
                    return false; // time is up.
                }

                return true;
            }
            catch (Exception e)
            {
                // failed.
            }

            return false;
        }

        // Use this to generate the token.
        public static string GetCredentials(string username, int userId)
        {
            var encoding = Encoding.GetEncoding("iso-8859-1");
            var credentials = username + "|" + userId + "|" + SecretNumber(username,userId) + "|" + DateTime.Now.Add(new TimeSpan(6,0,0));
            var credentialsBytes = encoding.GetBytes(credentials);
            var tokenized = Convert.ToBase64String(credentialsBytes);
            return tokenized;
        }

        private static string SecretNumber(string username, int userId)
        {
            // implement your own SecrentNumber algorithmn
            var firstPart = StringToInt(username) + 2020;
            var secretNumber= firstPart + userId;
            return secretNumber.ToString();
        }
        private static int StringToInt(string incoming)
        {
            var charray = incoming.ToCharArray();
            var intArray = charray.Select(m => (int)m);
            return intArray.Sum();
        }
    }
}
