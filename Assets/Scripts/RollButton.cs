using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollButton : MonoBehaviour
{

    public Button rollButton;
    public GameObject die1, die2;
    public GameObject player1;
    public GameObject player2;
    public int totalDice;

    public void Start()
    {
        //GetComponentInParent<Button>().AddListener(TaskOnClick);

      
           

    }

    public void TaskOnClick()
    {
       
       //Output this to console when Button1 or Button3 is clicked
       Debug.Log("You have clicked the button!");
        
       //totalDice = 0;

       StartCoroutine(die1.);

    }

    private IEnumerator RollDice()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("roll " + i);
            die1.GetComponent<Dice>().Roll();
            die2.GetComponent<Dice>().Roll();
            yield return new WaitForSeconds(.10f);
        }
        totalDice = die1.GetComponent<Dice>().value + die2.GetComponent<Dice>().value;
        //MovePlayer(totalDice);

    }
}
