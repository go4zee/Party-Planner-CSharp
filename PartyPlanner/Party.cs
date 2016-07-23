using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class Party
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if(FancyDecorations)
            {
                costOfDecorations = (Costs.FancyDecorationCostPerPerson * NumberOfPeople) + Costs.FancyDecorationFee;
            }
            else
            {
                costOfDecorations = (Costs.NormalDecorationCostPerPerson * NumberOfPeople) + Costs.NormalDecorationFee;
            }

            return costOfDecorations;
        }

        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += Costs.CostOfFoodPerson * NumberOfPeople;

                if (NumberOfPeople > 12)
                    totalCost += 100;

                return totalCost;
            }
        }
    }
}
