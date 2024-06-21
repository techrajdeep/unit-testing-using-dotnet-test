using System;
namespace CSharpDataType
{

    public class LoyalBuyer : Buyer{
        public int Discount{
            get;
            set;
        }
        public  LoyalBuyer(){
            Discount=10;
        }

        public override int getOrderByName(string? name){
            return 101;
        }
    }

    public static class BuyerFactory
    {
        public static Buyer Create(int orderCount){
            if(orderCount<=100){
                return new Buyer();
            }
            return new LoyalBuyer();
        }
    }
}