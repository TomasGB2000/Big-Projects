using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents1 : MonoBehaviour
{
    /***************************************************************************************
* Title: Events
* Author: Game Dev Guide
* Date: 2019
* Code version: N/A
* Availability: https://www.youtube.com/watch?v=gx0Lt4tCDE0
***************************************************************************************/

    public static GameEvents1 current;

    private void Awake()
    {
        current = this;
    }

    public event Action onDoorwayTriggerEnter1;

    public void DoorwayTriggerEnter1()
    {
        if (onDoorwayTriggerEnter1 != null)
        {
            onDoorwayTriggerEnter1();
        }
    }
}
