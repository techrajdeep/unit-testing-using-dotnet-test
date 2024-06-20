using CSharpDataType;
namespace CSharpDataTypesTests
{
    public class NumberDataTypesTest
    {
        [Fact]
        public void test_int_data_types()
        {
            var c= new IntDataTypes();
            var result=c.add(1,2);
            Assert.Equal(3,result);
        }
        [Fact]
        public void test_double_data_types(){
            var c= new DoubleDataTypes();
            var result=c.add(1.5,1.4);
            Assert.Equal(2.9,result);
        }
    }
}

