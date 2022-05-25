using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smoothing
{
    internal class SingleExponentialSmoothing
    {
        private double smoothingConstant = 0;
        private List<int> sales = new List<int>();
        private List<double> forecast = new List<double>();

        SingleExponentialSmoothing(double initialSmoothingConstant, List<int> initialSales)
        {
            this.sales = initialSales;
            this.smoothingConstant = initialSmoothingConstant;
        }

        public double calculateNewForecast()
        {
            return this.forecast[this.forecast.Count - 1] + this.smoothingConstant * (this.sales[sales.Count - 1] + this.forecast[this.forecast.Count - 1]);
        }

        public void addSale(int newSale)
        {
            this.sales.Add(newSale);
            calculateNewForecast();
        }

        public void addSales(List<int> newSales)
        {
            for (int i = 0; i < newSales.Count; i++)
            {
                this.sales.Add(newSales[i]);
                calculateNewForecast();
                
            }
        }

        
        

        

        
    }
}
