using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomList.Models
{    
    public class RandomData
    {        
        private static readonly Random rnd = new Random();
        // Source array - unsorted
        private int[] itemsSource;
        // Sorted array
        private int[] items;
        public int[] Items
        {
            get { return items; }
            set { items = value; }
        }
        // Array to sort by
        public Double[] order { get; set; }

        // Number of items in the array
        private int countItems = 0;
        
        public RandomData(int countNum)
        {
            countItems = countNum;
            // Initialize the source items.
            FillSource(countNum);
        }
        private void FillSource(int countNum)
        {
            // Initialize the source items.
            items = new int[countItems];
            itemsSource = new int[countItems];            
            for (int i = 0; i < itemsSource.Length; i++)
            {
                itemsSource[i] = i + 1;
            }
        }        
        public int[] SortRandomData()        
        {           
            // Initialize the order array.
            //Items = new int[count];
            order = new Double[countItems];
                        
            Array.Copy(itemsSource, items, countItems); //??

            // Refiil the order array with random numbers
            for (int iOrd = 0; iOrd < order.Length; iOrd++)
                order[iOrd] = rnd.NextDouble();

            // Sort items array by updated order array values
            Array.Sort(order, items);
                       
            //string.Join(" ", Items);
            return items;
        }

        public override string ToString()
        {
            return string.Join(", ", items);
        }              
    }
}

