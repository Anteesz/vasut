using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VasuthaloAlt.RailwayException;
using VasuthaloAlt.Repository;
using VasuthaloAlt.Model.UserHandling;

namespace VasuthaloAlt.Authenticator
{
    public sealed class UserAuthenticator
    {
        public static User? LoggedInUser { get; set; }
        private static UserContext userContext = userContext.Instance;

        private UserAuthenticator() { }
        public static User Authenticate(string username, string password)
        {
            User? user = userContext.Users.FirstOrDefault(user => user.Username == username);
            if (user==null)
            {
                throw new VasuthalozatException("Hibás felhasználónév!");
            }
            if (!Bcrypt.Net.Bcrypt.Verify(password, user.Password))
            {
                throw new VasuthalozatException("Hibás jelszó!");
            }
            LoggedInUser = user;
            return user;
        }
    }
}
