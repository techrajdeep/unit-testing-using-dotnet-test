using Xunit;
using CSharpDataType;
namespace CSharpDataTypesTests
{
    public class CustomerTest
    {
        [Fact]
        public void TestName()
        {
            // Given
            // When
            var customer = new Customer();
            // Then
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }
        [Fact]
        public void Test_ageIsInTheRangeOf25_to_50()
        {
            // Given
            var customer = new Customer();
            // When
        
            // Then
            Assert.InRange(customer.Age, 25,50);
        }
    }
}