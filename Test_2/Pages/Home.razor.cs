using Test_2.Models;

namespace Test_2.Pages
{
    public partial class Home
    {

        Polozka Item = new Polozka();
        bool IsEdited = false;

        List<Polozka> items_List = new List<Polozka>(){

            { new Polozka { Prop_Name="JBL", Prop_Price=7500 } },
            { new Polozka { Prop_Name="NOC", Prop_Price=7500,Prop_Status=Status.Complete,Prop_Enabled=true } },
            { new Polozka { Prop_Name="NOC", Prop_Price=800} },

        };

        public void SubmitItem()
        {
            if (!IsEdited) { 
                items_List.Add(Item);
                IsEdited = false;
            }
            Item = new Polozka();
            StateHasChanged();
        }

        public void DeleteItem(Polozka item) { 
            items_List.Remove(item);
            StateHasChanged();
        }
        public void Done(Polozka item)
        {
            if (item.Prop_Status == Status.Complete)
            {
                item.Prop_Status = Status.Waiting;
                item.Prop_Enabled = false;
            }
            else
            {
                item.Prop_Status = Status.Complete;
                item.Prop_Enabled = true;
            }
            StateHasChanged();
        }
        public void EditItem(Polozka item)
        {
            Item = item;
            IsEdited = true;
            StateHasChanged();
        }
        public double GetPrice(int a)
        {
            double loc_price = 0;
            if (a == 1){
                foreach (var item in items_List)
                {
                    if (item.Prop_Enabled)
                    {
                        loc_price += item.Prop_Price;
                    }
                }
            }
            else
            {
                foreach (var item in items_List)
                {
                    if (!item.Prop_Enabled)
                    {
                        loc_price += item.Prop_Price;
                    }
                }
            }
           
            return loc_price;
            

        }
    }
}
