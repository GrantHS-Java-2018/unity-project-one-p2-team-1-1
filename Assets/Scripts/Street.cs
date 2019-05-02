using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Street : Property
{
    protected override int CaluclateRent()
    {
        return 0;
        //return rentValues[(monopoly ? 1 : 0) + houseCount + (hasHotel ? 1 : 0)];
    }
   
}
