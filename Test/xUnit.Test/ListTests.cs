using Xunit;
using System.Linq;
using RandomList.Models;


namespace Tests
{
    public class ListTests
    {
        int countItems;
        int minItem;
        int maxItem;        
        
        // Init test data
        public void Init()
        {
            countItems = 10000;
            minItem = 1;
            maxItem = 10000;            
        }
        // Each number in the list must be unique
        [Fact]
        public void RandomListValuesMustBeUnique()
        {
            Init();
            RandomData rnd = new RandomData(countItems);
            RandomItem[] result = rnd.SortRandomData();
                  
            int countResult = result.Distinct().Count();
            Assert.Equal(countResult, countItems);
        }
        // Min number in the list must be 1
        [Fact]
        public void RandomListMinValueMustBeEqual1()
        {
            Init();
            RandomData rnd = new RandomData(countItems);
            rnd.SortRandomData();
            Assert.Equal(rnd.Min(), minItem);
        }
        // Min number in the list must be 10000
        [Fact]
        public void RandomListMaxValueMustBeEqual10000()
        {
            Init();
            RandomData rnd = new RandomData(countItems);
            rnd.SortRandomData();            
            Assert.Equal(rnd.Max(), maxItem);
        }
    }
}
