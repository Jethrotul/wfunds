using System.ComponentModel.DataAnnotations.Schema;

namespace Funds.Data
{
    public class Fund
    {
        public int FundId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Country { get; set; }

        public string FundTypeName { get; set; }

        public FundType FundType { get; set; }
    }
}
