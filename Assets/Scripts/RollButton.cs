using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollButton : MonoBehaviour
{
<<<<<<< HEAD
    public Boolean rollButteonPress = false;
    public Boolean pressRoll = false
    private int button;
    public Button m_YourFirstButton;
    public GameObject dice1, dice2;
    public GameObject Player1;
=======

    public Button rollButton;
    public GameObject die1, die2;
    public GameObject player1;
    public GameObject player2;
    public int totalDice;

    public void Start()
    {
        //GetComponentInParent<Button>().AddListener(TaskOnClick);

      
           
>>>>>>> roll-move

    public int totalDice;

    void Start()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
        
<<<<<<< HEAD
=======
       //totalDice = 0;

       StartCoroutine(die1.);

>>>>>>> roll-move
    }

    void TaskOnClick()
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
