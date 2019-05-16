using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Street : Property
{
    protected override int CalculateRent()
    {
        return 0;
        //return rentValues[(monopoly ? 1 : 0) + houseCount + (hasHotel ? 1 : 0)];
    }
   
}
