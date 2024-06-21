using System;
namespace CSharpDataType
{
    public class Buyer 
    {
        public virtual int getOrderByName(string? name){
            if(string.IsNullOrEmpty(name)){
                throw new ArgumentException("Hello");
            }
            return 100;
        }

    }
}