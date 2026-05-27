using PremiumCalculator.Core.Interfaces;
using PremiumCalculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Infrastructure.Services
{
    public class PremiumService
    {
        private readonly IOccupationRepository _repository;

        public PremiumService(IOccupationRepository repository)
        {
            _repository = repository;
        }

        public double CalculatePremium(MemberModel model)
        {
            double factor = _repository.GetRatingFactor(model.Occupation);

            double premium =
                (model.DeathSumInsured * factor * model.AgeNextBirthday)
                / 1000 * 12;

            return Math.Round(premium, 2);
        }
    }
}
