﻿using UnityEngine;

public class FollowThePath : MonoBehaviour
{

    public Transform[] waypoints = new Transform[40];

    [SerializeField] private float moveSpeed = 1f;

    [HideInInspector] public int waypointIndex = 40;

    public bool moveAllowed = false;

    // Use this for initialization
    private void Start()
    {
        
       // transform.position = waypoints[waypointIndex -1].transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (moveAllowed)
            Move();
    }


    public void Move()
    {

        int total = GetComponent<RollButton>().totalDice;
        
        if (waypointIndex <= waypoints.Length - 1 && total >= 0)
       
        {
            transform.position = Vector2.MoveTowards(transform.position,
                waypoints[waypointIndex].transform.position,
                moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
                total--;
            }
        }
    }
}

