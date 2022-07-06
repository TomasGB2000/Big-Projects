using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents5 : MonoBehaviour
{
    /***************************************************************************************
* Title: Events
* Author: Game Dev Guide
* Date: 2019
* Code version: N/A
* Availability: https://www.youtube.com/watch?v=gx0Lt4tCDE0
***************************************************************************************/

    public static GameEvents5 current;

    private void Awake()
    {
        current = this;
    }

    public event Action onDoorwayTriggerEnter5;

    public void DoorwayTriggerEnter5()
    {
        if (onDoorwayTriggerEnter5 != null)
        {
            onDoorwayTriggerEnter5();
        }
    }
}
