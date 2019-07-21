﻿using System.Collections.Generic;

namespace WAG.ViewModels.UserAccount
{
    public class UserDetailsViewModel
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public List<string> IdentityRoles { get; set; }
    }
}
