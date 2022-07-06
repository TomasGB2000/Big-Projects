using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents6 : MonoBehaviour
{
    /***************************************************************************************
* Title: Events
* Author: Game Dev Guide
* Date: 2019
* Code version: N/A
* Availability: https://www.youtube.com/watch?v=gx0Lt4tCDE0
***************************************************************************************/

    public static GameEvents6 current;

    private void Awake()
    {
        current = this;
    }

    public event Action onDoorwayTriggerEnter6;

    public void DoorwayTriggerEnter6()
    {
        if (onDoorwayTriggerEnter6 != null)
        {
            onDoorwayTriggerEnter6();
        }
    }
}
