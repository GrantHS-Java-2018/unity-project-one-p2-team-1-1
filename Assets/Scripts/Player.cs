using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;


public class Player : MonoBehaviour
{
    public GameObject dice1, dice2;

    public GameObject Button;

    public GameObject[] waypointArray;
    private Waypoint currentWaypoint;
    private int stopRolling = 1;
    private int doublesCounter = 0;
    public GameObject jailWaypoint;

    void Srart()
    {
        transform.position = new Vector3(waypointArray[waypointIndex].transform.postition.x, waypointArray[waypointIndex].transform.position.y, 0);
    }

    public void followWaypoint()
    {
        if (stopRolling == 1)
        {
            Doubles();
            for (int i = 0; 1 < dice2.GetComponent<Dice>().value + dice1.GetComponent<Dice>().value; i++)
            {
                transform.postion = new Vector3(waypointArray[waypointIndex +1].transform.position.x,
                    waypointArray[waypointIndex +1]. transform.position.y, 0);
                waypointIndex++;
            }

            stopRolling = 2;
            
        }
        else
        {
            stopRolling = 1;
        }

        void doubles()
        {
            Boolean???
            if()
        }
        
    }
}
