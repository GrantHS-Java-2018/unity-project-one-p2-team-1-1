using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Currency : MonoBehaviour
{
    int totalP1 = 1500;
    int totalP2 = 1500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (totalP1 <= 0) ;
        {
            WhoWinsText.GetComponent<Text>().enabled = true;
        }
    }

    public Currency()
    {
 
    }

    public void AddMoney()
    {
        totalP1 = totalP1 + //card value
    }
    
    public void RemoveMoney()
    {
        totalP1 = totalP1 - //card value
    }
    
    public void PayToPlayer1()
    {
        totalP1 = totalP1 + //card value
        totalP2 = totalP2 + //card value
    }
    public void PayToPlayer2()
    {
        totalP2 = totalP2 + //card value
        totalP1 = totalP1 + //card value
    }
    
    
   
    
}



