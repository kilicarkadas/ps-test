using System;
namespace OrderingApi.Models
{
    public class Order
    {
        public int Id { get; set; }

        public Int64 CompanyId { get; set; }

        public string TerminalName { get; set; }

        public int TerminalNumber { get; set; }

        public DateTime Created { get; set; }
    }
}
