using Xunit;
using System.Linq;
using RandomList.Models;
using System.Text.RegularExpressions;

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
        // Colors must be a valid RGBA string
        [Fact]
        public void RandomColorMustBeValidHexadecimal()
        {
            Init();
            RandomData rnd = new RandomData(countItems);
            rnd.SortRandomData();
          
            // Regex object with validation pattern
            var re = new Regex(@"^rgba\(\s*(\d{1,3}\s*\,\s*){3}?(\d\.?\d*){1}?\s*\)$(?i)(?x)");    
            int count = rnd.Items.Length - 1;

            // Check all RGBA values
            for (int i=0; i<count; i++)
            {
                string input = rnd.Items[i].ItemRGBAValue.Trim();                
                bool result = re.IsMatch(rnd.Items[i].ItemRGBAValue.Trim());
                              
                Assert.True(result, string.Format("Not valid color RGBA {0}", input));
            }          
        }
    }
}