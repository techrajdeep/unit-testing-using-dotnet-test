using Xunit;
using CSharpDataType;

namespace CSharpDataTypeTests
{
    public class ObjectDataTypeTest
    {
        [Fact]
        public void Test_Object_Type_Buyer()
        {
            // Given
             
            // When
             var buyer=  BuyerFactory.Create(100);
            // Then
            Assert.IsType<Buyer>(buyer);
        }
        [Fact]
        public void Test_Object_Type_Loyal_Buyer()
        {
            // Given
        
            // When
            var buyer=  BuyerFactory.Create(105);
            // Then
            var loyalBuyer=Assert.IsType<LoyalBuyer>(buyer);
            Assert.Equal(10,loyalBuyer.Discount);
        }
    }
}