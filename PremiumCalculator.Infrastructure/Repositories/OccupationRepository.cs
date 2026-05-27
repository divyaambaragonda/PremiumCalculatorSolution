using PremiumCalculator.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Infrastructure.Repositories
{
    public class OccupationRepository : IOccupationRepository
    {
        public double GetRatingFactor(string occupation)
        {
            return occupation switch
            {
                "Doctor" => 1.5,
                "Author" => 2.25,
                "Cleaner" => 11.50,
                "Florist" => 11.50,
                "Farmer" => 31.75,
                "Mechanic" => 31.75,
                _ => 31.75
            };
        }
    }
}
