using System;
using System.Linq;

namespace RandomList.Models
{
    // Class with pair of properties: int and hex    
    public class RandomItem: IComparable<int>
    {
        // Random integer
        public int ItemValue { get; set; }
        // Color hex value for color rendering 
        public string ItemHexValue { get; set; }

        // Initialize empty
        public RandomItem()
        {
            ItemValue = 0;
            ItemHexValue = "";
        }
        // Initialize with data
        public RandomItem(int num)
        {            
            ItemValue = num;
            // Convert ItemValue to Hex for color rendering         
            ItemHexValue = num.ToString("X");           
        }

        // IComparable implementation 
        public int CompareTo(int num)
        {
            return this.ItemValue.CompareTo((num));            
        }        
    }

    // Class to generate random numbers
    public class RandomData
    {   
        // Preudo-random number generator    
        private static readonly Random rnd = new Random();
        // Array to preserve initial values
        private RandomItem[] itemsSource;
        // Array to be sorted
        private RandomItem[] items;
        // Array of items with numbers
        public RandomItem[] Items
        {
            get { return items; }
            set { items = value; }
        }
        // Array to sort by
        public Double[] order { get; set; }

        // Number of random items to generate
        private int countItems = 0;
        

        // Initialize
        public RandomData(int countNum)
        {
            // Set the number of random numbers to generate
            countItems = countNum;

            // Initialize the items to be sorted.
            items = new RandomItem[countItems];

            // Initialize and fill array with the items to be preserved.
            itemsSource = new RandomItem[countItems];
            FillSource(countNum);
        }
        // Run once on creating instance.
        // Fill array with integers from 1 to count Items
        private void FillSource(int countNum)
        {
            for (int i = 0; i < itemsSource.Length; i++)
            {              
                itemsSource.SetValue(new RandomItem(i + 1), i);
            }
        }
        // Get next random numbers into order array and sort items array by the new values
        public RandomItem[] SortRandomData()        
        {           
            // Initialize the order array.            
            order = new Double[countItems];
            
            // Reset items array           
            Array.Copy(itemsSource, items, countItems);

            // Refill the order array with random numbers
            for (int iOrd = 0; iOrd < order.Length; iOrd++)
                order[iOrd] = rnd.NextDouble();

            // Sort items array by updated order array
            Array.Sort(order, items);                       
            
            return items;
        }
        // Return Min value of the random numbers items
        public int Min()
        {            
            if(items == null)
            {
                return 0;
            }
            return items.Min(item => item.ItemValue);          
        }
        // Return Max value of the random numbers items
        public int Max()
        {
            if (items == null)
            {
                return 0;
            }
            return items.Max(item => item.ItemValue);
        }
    }
}

