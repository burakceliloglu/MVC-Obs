﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.CommonServices.Abstract;

namespace Business.AuthorizationServices.Abstract
{
    public interface IAuthService
    {
        Task<bool> SingInAsync(string email, string password);
        Task SingOutAsync();
    }
}
