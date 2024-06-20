using Xunit;
using CSharpDataType;

namespace CSharpDataTypesTests{
    public class StringDataTypeTest{
        [Fact]
        public void TestStringDataType(){
            var data = new StringDataTypes();
            var result= data.fullName("Rajdeep","Sahoo");
            Assert.Equal("Rajdeep Sahoo",result);
        }
    }
}