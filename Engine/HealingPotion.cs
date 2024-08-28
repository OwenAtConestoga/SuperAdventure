using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Engine
{
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; set; }
        int cry = 100;
        int why = 0;


        public HealingPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }//if this works ill cry
    //test commit
}