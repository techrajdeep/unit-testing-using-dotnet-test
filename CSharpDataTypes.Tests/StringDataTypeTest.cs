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

        [Fact]
        public void Test_Null_nickname(){
            var data = new StringDataTypes();
            Assert.Null(data.nickName);
        }

        [Fact]
        public void Test_FullName_Non_Empty()
        {
            // Given
            var data = new StringDataTypes();
            // When
            var result=data.fullName("Abc","Def");
            // Then
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}