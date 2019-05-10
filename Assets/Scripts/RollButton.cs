using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollButton : MonoBehaviour
{

    public Button rollButton;
    public GameObject dice1, dice2;
    public GameObject player1;
    public GameObject player2;
    public int totalDice;

    public void Start()
    {
        rollButton.onClick.AddListener(TaskOnClick);

      
           

    }

     void TaskOnClick()
        {
           
           //Output this to console when Button1 or Button3 is clicked
           Debug.Log("You have clicked the button!");
            
           //totalDice = 0;


           StartCoroutine(dice1.GetComponent<Dice>().Roll());
           StartCoroutine(dice2.GetComponent<Dice>().Roll());
           totalDice = dice1.GetComponent<Dice>().value + dice2.GetComponent<Dice>().value;

        }
}
