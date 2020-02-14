using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    public class Product
    {
        // List of parts that have been associated to product
        private BindingList<Part> associatedParts = new BindingList<Part>();
        public BindingList<Part> productsAssociatedParts { get { return associatedParts; } set { associatedParts = value; } }

        // Instance Variables
        private int productID;
        private string name;
        private int inStock;
        private double price;
        private int max;
        private int min;

        //Constructors
        public Product(int ID, string productName, int productInStock, double productPrice, int productMax, int productMin)
        { 
            productID = ID;
            name = productName;
            inStock = productInStock;
            price = productPrice;
            max = productMax;
            min = productMin;
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

        public void setProductID(int ID)
        {
            productID = ID;
        }

        public int getProductID()
        {
            return productID;
        }

        // associatedParts Functions
        public void addAssociatedPart(Part part)
        {
            associatedParts.Add(part);
            // associatedPartsCount++;
        }

        public Part getAssociatedPart(int index)
        {
            return associatedParts[index];
        }

        public int getAssociatedPartCount()
        {
            return associatedParts.Count;
        }

        public Boolean removeAssociatePart(int ID)
        {
            for(int i = 0; i < associatedParts.Count; i++)
            {
                if (associatedParts[i].getPartID() == ID)
                {
                    associatedParts.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public Part lookupAssociatedPart(int ID)
        {
            for (int i = 0; i < associatedParts.Count; i++)
            {
                if (associatedParts[i].getPartID() == ID)
                {
                    MainForm.selectedPartIndex = i;
                    return associatedParts[i];
                }
            }
            MainForm.selectedPartIndex = -1;
            return null;
        }
    }
}
