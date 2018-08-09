using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRouletProject
{
    public class Functions
    {
        // Function For Combobox Age Group on Form 2

        public string[] LoadAgeStrings()
        {
            //an array of Age Groups
            string[] comboBoxItems = new String[] { "18 to 25" ,  "25 to 35" , "35 to 45" ,
                 "45 to 55"  , "55 to 65" ,  "65 to 75" , "75 +" };
            return comboBoxItems;
        }
        


    }

    
    
}
