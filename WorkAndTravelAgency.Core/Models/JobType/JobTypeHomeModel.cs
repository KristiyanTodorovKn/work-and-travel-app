using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAndTravelAgency.Core.Models.JobType
{
    public class JobTypeHomeModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Salary { get; set; }
    }
}
