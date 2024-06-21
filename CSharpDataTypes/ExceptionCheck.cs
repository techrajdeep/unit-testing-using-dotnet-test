namespace CSharpDataType
{
    public class Buyer 
    {
        public int getOrder(string? name){
            if(string.IsNullOrEmpty(name)){
                throw new ArgumentException("Hello");
            }
            return 100;
        }

    }
}