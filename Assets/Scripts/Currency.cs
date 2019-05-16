using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{

    public GameObject WhoWinsText;
    public GameObject player1, player2;
    int bank = 9999999;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Currency()
    {

    }

    public void AddMoneyToP1()
    {
        player1.GetComponent<Wallet>().money += 0; //card value
        
    }
    public void AddMoneyToP2()
    {
        player2.GetComponent<Wallet>().money  += 0; //card value
       
    }
    public void RemoveMoneyToP1()
    {
        player1.GetComponent<Wallet>().money -= 0; //card value
        if (player1.GetComponent<Wallet>().money <= 0) ;
        {
            WhoWinsText.GetComponent<Text>().enabled = true;
        }
    }
    public void RemoveMoneyToP2()
    {
        player2.GetComponent<Wallet>().money -= 0; //card value
        if (player2.GetComponent<Wallet>().money <= 0) ;
        {
            WhoWinsText.GetComponent<Text>().enabled = true;
        }
    }

    public void PayToPlayer1(int value)
         {
             player1.GetComponent<Wallet>().money += value; //card value
             player2.GetComponent<Wallet>().money -=  100; //card value
             if (player2.GetComponent<Wallet>().money <= 0) ;
             {
                 WhoWinsText.GetComponent<Text>().enabled = true;
             }
     
         }
    
    public void PayToPlayer2()
    {
        player2.GetComponent<Wallet>().money += 100; //card value
        player1.GetComponent<Wallet>().money -=  100; //card value
        if (player1.GetComponent<Wallet>().money <= 0) ;
        {
            WhoWinsText.GetComponent<Text>().enabled = true;
        }
     
    }
}



