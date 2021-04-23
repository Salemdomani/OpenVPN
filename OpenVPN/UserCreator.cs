using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OpenVPN
{
    static class UserCreator
    {
        public static User CreateUser(string name,string password)
        {
            return new User(name, password);
        }

        public static User CreateRandomUser()
        {
            return new User("usr"+RandomString(5), "pass"+ RandomString(5));
        }

        private static string RandomString(int length)
        {
            // Why RNGCryptoServiceProvider ??
            // Because it's safer to build strings with it than Random class
            var valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }

    }
}
