using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Property: GameTile
{
    
    public int tileMortgage;
    public int tileUnmortgage;
    public int tilePrice;
    public GameObject owner; 
    public int tileRent => CalculateRent();

    protected abstract int CalculateRent();


}