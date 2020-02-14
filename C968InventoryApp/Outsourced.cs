using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    class Outsourced : Part
    {
        // Instance Variables
        private string companyName;

        // Constructor
        public Outsourced(int ID, string partName, int partInStock, double partPrice, int partMax, int partMin, string partCompanyName)
            : base(ID, partName, partInStock, partPrice, partMax, partMin)
        {
            companyName = partCompanyName;
        }

        // Getter & Setter Functions
        public string getCompanyName()
        {
            return companyName;
        }

        public void setCompanyName(string name)
        {
            companyName = name;
        }
    }
}
