using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    public abstract class Part
    {
        // Instance Variables
        private int partID;
        private string name;
        private int inStock;
        private double price;
        private int max;
        private int min;

        // Constructors
        public Part(int ID, string partName, int partInStock, double partPrice, int partMax, int partMin)
        {
            partID = ID;
            name = partName;
            inStock = partInStock;
            price = partPrice;
            max = partMax;
            min = partMin;
        }

        // Getter & Setter Functions
        public void setName(string Name)
        {
            name = Name;
        }

        public string getName()
        {
            return name;
        }

        public void setPrice(double Price)
        {
            price = Price;
        }

        public double getPrice()
        {
            return price;
        }

        public void setInStock(int stock)
        {
            inStock = stock;
        }

        public int getInStock()
        {
            return inStock;
        }

        public void setMin(int Min)
        {
            min = Min;
        }

        public int getMin()
        {
            return min;
        }

        public void setMax(int Max)
        {
            max = Max;
        }

        public int getMax()
        {
            return max;
        }

        public void setPartID(int ID)
        {
            partID = ID;
        }

        public int getPartID()
        {
            return partID;
        }
    }
}
