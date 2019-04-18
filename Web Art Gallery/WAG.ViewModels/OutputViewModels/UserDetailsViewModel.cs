﻿using System;
using System.Collections.Generic;
using System.Text;
using WAG.Data.Models;

namespace WAG.ViewModels.OutputViewModels
{
    public class UserDetailsViewModel
    {
        public WAGUser User { get; set; }

        public List<string> IdentityRoles { get; set; }
    }
}
