using System.ComponentModel.DataAnnotations.Schema;

namespace Funds.Data
{
    public class Fund
    {
        public int FundId { get; set; }
        public string Isin { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double AReturn { get; set; }
        public double A5Return { get; set; }
        public string Manager { get; set; }
        public string Category { get; set; }
        public string FundTypeName { get; set; }
        public FundType FundType { get; set; }
    }
}
