using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Funds.Data;

namespace Funds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundsController : ControllerBase
    {
        private readonly FundsContext fundsContext;

        public FundsController(FundsContext fundsContext)
        {
            this.fundsContext = fundsContext;
        }

        public async Task<Fund[]> GetFunds()
        {
            return await fundsContext.Funds.ToArrayAsync();
        }
    }
}