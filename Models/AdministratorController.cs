﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Models
{
    [Authorize(Roles = "Administrator")]
    public class AdministratorController : Controller
    {
        
    }
}
