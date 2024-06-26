using CSharpDataType;
namespace CSharpDataTypesTests
{
    public class ExceptionCheckTest{
        [Fact]
        public void Test_ExceptionForNullParam()
        {
            var c = new Buyer();
            Assert.Throws<ArgumentException>(() => c.getOrderByName(null));
        }
        [Fact]
        public void Test_Validate_exception_value()
        {
            // Given
             var c = new Buyer();
            // When
            var result = Assert.Throws<ArgumentException>(()=>c.getOrderByName(""));
            // Then
            Assert.Equal("Hello", result.Message);
        }
    }
}