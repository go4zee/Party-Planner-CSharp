using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            return costOfBeveragesPerPerson;
        }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += CalculateCostOfBeveragesPerPerson() * NumberOfPeople;              

                if (HealthyOption)
                {
                    totalCost *= 0.95M;
                }
                return totalCost;
            }
        }

        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }

        public DinnerParty(int Number_Of_People, bool Healthy_Option, bool fancy_Option)
        {
            this.NumberOfPeople = Number_Of_People;
            this.HealthyOption = Healthy_Option;
            this.FancyDecorations = fancy_Option;

        }
    }
}
