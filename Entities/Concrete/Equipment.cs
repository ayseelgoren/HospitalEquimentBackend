using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Equipment : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ProcurementDate { get; set; }
        public int Piece { get; set; }
        public double UnitPrice { get; set; }
        public double UsageRate { get; set; }
        public int ClinicId { get; set; }
    }
}
