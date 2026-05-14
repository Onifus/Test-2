
namespace Test_2.Models
{
    public class Polozka
    {

        // jméno účastníka, email účastníka, datum registrace, výši vložného, příznak, zda bylo vložné zaplaceno
        public string Prop_Name { get; set; }
        public double Prop_Price { get; set; }
        public Status Prop_Status { get; set; } = Status.Waiting;
        public bool Prop_Enabled { get; set; } = false;


    }


}
