using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    class Inhouse : Part
    {
        // Instance Variables
        private int machineID;

        // Construtors
        public Inhouse(int ID, string partName, int partInStock, double partPrice, int partMax, int partMin, int partMachineID)
            : base(ID, partName, partInStock, partPrice, partMax, partMin)
        {
            machineID = partMachineID;
        }

        // Getter & Setter Functions
        public void setMachineID(int ID)
        {
            machineID = ID;
        }

        public int getMachineID()
        {
            return machineID;
        }
    }
}
