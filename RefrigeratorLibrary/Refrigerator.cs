using System;
using System.Collections.Generic;
using System.Text;

namespace RefrigeratorLibrary
{
    public class Refrigerator : BaseRefrigerator
    {
        public Refrigerator() { }

        public Refrigerator(string brand, string model, EnergyEfficiencyClass efficiency, int power, int totalVol, int fridgeVol)
            : base(brand, model, efficiency, power, totalVol, fridgeVol) { }
    }
}
