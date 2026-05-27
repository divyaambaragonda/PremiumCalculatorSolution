using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Core.Interfaces
{
    public interface IOccupationRepository
    {
        double GetRatingFactor(string occupation);
    }
}
