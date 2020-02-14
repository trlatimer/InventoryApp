using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    class Inventory
    {
        // List of Products within program
        private static BindingList<Product> productsList = new BindingList<Product>();
        public static BindingList<Product> Products { get { return productsList; } set { productsList = value; } }

        // List of Parts within program
        private static BindingList<Part> allPartsList = new BindingList<Part>();
        public static BindingList<Part> AllParts { get { return allPartsList; } set { allPartsList = value; } }

        // Counts for parts and products -- Used for incrementing ID's when adding new items
        public static int partsCount {get; set;}
        public static int productsCount { get; set; }

        // Add a new product
        public static void addProduct(Product product)
        {
            // Add to Products list
            Products.Add(product);
            // Increment counter
            productsCount++;
        }

        // Remove a product
        public static Boolean removeProduct(int ID)
        {
            // Loop through all products
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                // Compare each productID to productID returned by Product ID Cell in selected row
                if (Inventory.Products[i].getProductID() == MainForm.selectedProduct.getProductID())
                {
                    // If matching ID's are found, remove product
                    //Console.WriteLine("ID in Inventory = " + $"{Inventory.Products[i].getProductID()}");
                    //Console.WriteLine("ID of Selected = " + $"{MainForm.selectedProduct.getProductID()}");
                    Console.WriteLine("ID's match. Deleting product...");
                    Inventory.Products.RemoveAt(i);
                    Console.WriteLine("Product removed.");
                    return true;
                }
            }
            // If no matching ID's found, display dialogue
            Console.WriteLine("Unable to locate matching Product. Deletion failed.");
            return false;
        }

        // Lookup a specific product
        public static Product lookupProduct(int ID)
        {
            // Loop through all products
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                // If matching ID's are found, set selected index and return Product instance
                if (Products[i].getProductID() == ID)
                {
                    MainForm.selectedProductIndex = i;
                    return Products[i];
                }
            }
            // reset Product index if no matching ID's are found and return null
            MainForm.selectedProductIndex = -1;
            return null;
        }

        // Update a product
        public static void updateProduct(int index, Product updatedProduct)
        {
            // Insert new product at location of product to replace
            Inventory.Products.Insert(index, updatedProduct);
            // Remove old instance of product
            Inventory.Products.RemoveAt(index + 1);
        }

        // Add a new part
        public static void addPart(Part part)
        {
            // Add Part to the AllParts list and increment counter
            AllParts.Add(part);
            partsCount++;
        }

        // Delete a part
        public static Boolean deletePart(Part part)
        {
            // Loop through all parts
            for (int i=0; i < Inventory.AllParts.Count; i++)
                 {
                 // Compare each partID to partID returned by Part ID Cell in selected row
                 if (Inventory.AllParts[i].getPartID() == part.getPartID())
                     {
                        // If Matching ID's are found, remove part
                         Console.WriteLine("ID's match. Deleting part...");
                         Inventory.AllParts.RemoveAt(i);
                         Console.WriteLine("Part removed.");
                         return true;
                 }
             }
            // If no matching ID's are found, display dialogue and return false
            Console.WriteLine("Unable to locate matching Part.");
            return false;
        }

        // Lookup a specific part
        public static Part LookupPart(int ID)
        {
            // Loop through all parts
            for(int i = 0; i < Inventory.AllParts.Count; i++)
            {
                // If ID within list matches ID provided, return part an set index to index of part
                if (AllParts[i].getPartID() == ID)
                {
                    MainForm.selectedPartIndex = i;
                    return AllParts[i];
                }
            }
            // If no ID match found in list, reset index and return null
            MainForm.selectedPartIndex = -1;
            return null;
        }

        // Update a specific part
        public static void updatePart(int ID, Part updatedPart)
        {
            // Insert new part in location of old part
            Inventory.AllParts.Insert(ID, updatedPart);
            // Remove instance of old part
            Inventory.AllParts.RemoveAt(ID + 1);
        }
    }
}
