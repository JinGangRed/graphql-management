using Domain.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Controllers
{
    [Produces("application/json")]
    public class BaseController:Controller
    {
        protected readonly RepositoryContext context;
        
        public BaseController(RepositoryContext context)
        {
            this.context = context;
        }
    }
}
