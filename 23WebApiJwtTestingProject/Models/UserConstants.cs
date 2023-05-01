using System;
using System.Collections.Generic;

namespace _23WebApiJwtTestingProject.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "Username1", EmailAddress = "email.admin1@email.com", Password = "password1", GivenName = "GivenName1", Surname = "Surname", Role = "Administrator" },
            new UserModel() { Username = "Username2", EmailAddress = "email.seller@email.com", Password = "password2", GivenName = "GivenName2", Surname = "Surname", Role = "Seller" },
        };
    }
}