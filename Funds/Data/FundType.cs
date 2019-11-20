using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Funds.Data
{
    public class FundType
    {
        public string Name { get; set; }

        public List<Fund> Funds { get; set; }
    }
}
