using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Core.Models
{
    public class MemberModel
    {
        public string Name { get; set; }

        public int AgeNextBirthday { get; set; }

        public string DateOfBirth { get; set; }

        public string Occupation { get; set; }

        public double DeathSumInsured { get; set; }
    }
    public enum OccupationRating
    {
        Professional,
        WhiteCollar,
        LightManual,
        HeavyManual
    }
}
