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

    public void TaskOnClick()
    {
       
       //Output this to console when Button1 or Button3 is clicked
       Debug.Log("You have clicked the button!");
        
       //totalDice = 0;

       StartCoroutine(RollDice());

    }

    private IEnumerator RollDice()
    {
        for (int i = 0; i < 10; i++)
        {
            dice1.GetComponent<Dice>().Roll();
            dice2.GetComponent<Dice>().Roll();
            yield return new WaitForSeconds(.10f);
        }
        totalDice = dice1.GetComponent<Dice>().value + dice2.GetComponent<Dice>().value;
        MovePlayer(totalDice);

    }
}
