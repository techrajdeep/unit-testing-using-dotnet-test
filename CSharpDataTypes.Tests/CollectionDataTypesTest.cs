using Xunit;
using CSharpDataType;

namespace CSharpDataType.Tests
{
    public class CollectionDataTypeTest
    {
        [Fact]
        public void TestCollectionDataType(){
            var data = new CollectionDataType();
            Assert.All(data.fibbonacci, x => Assert.NotEqual(0,x));
        }
        [Fact]
        public void Test_Fibbonacci_List_Contains13()
        {
            // Given
            var data = new CollectionDataType();
            // When
        
            // Then
            Assert.Contains(13,data.fibbonacci);
        }
        [Fact]
        public void Test_Fibbonacci_List_Not_Contains4()
        {
            // Given
                var data = new CollectionDataType();
            // When
            // Then
            Assert.DoesNotContain(4,data.fibbonacci);
        }
        [Fact]
        public void Test_check_Collection_values()
        {
            // Given
            var list = new List<int>(){1,1,2,3,5,8,13};
            // When
            var data=new CollectionDataType();
            // Then
            Assert.Equal(list,data.fibbonacci);
        }
    }
}