using System;
using Xunit;
using System.Linq;
using RandomList.Models;
using RandomList.Controllers;
using System.Collections.Generic;


namespace Tests
{
    public class ListTests
    {
        int countItems;
        int minItem;
        int maxItem;        
        
        public void Init()
        {
            countItems = 10000;
            minItem = 1;
            maxItem = 10000;            
        }

        [Fact]
        public void RandomListValuesMustBeUnique()
        {
            Init();
            RandomData rnd = new RandomData(countItems);
            
            int[] result = rnd.SortRandomData();
            int countResult = result.Distinct().Count();
            Assert.Equal(countResult, countItems);
        }
        [Fact]
        public void RandomListMinValueMustBeEqual1()
        {
            Init();
            RandomData rnd = new RandomData(countItems);

            int[] result = rnd.SortRandomData();            
            Assert.Equal(result.Min(), minItem);
        }
        [Fact]
        public void RandomListMaxValueMustBeEqual10000()
        {
            Init();
            RandomData rnd = new RandomData(countItems);

            int[] result = rnd.SortRandomData();            
            Assert.Equal(result.Max(), maxItem);
        }
    }
}
