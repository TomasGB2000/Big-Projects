using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents2 : MonoBehaviour
{
    /***************************************************************************************
* Title: Events
* Author: Game Dev Guide
* Date: 2019
* Code version: N/A
* Availability: https://www.youtube.com/watch?v=gx0Lt4tCDE0
***************************************************************************************/

    public static GameEvents2 current;

    private void Awake()
    {
        current = this;
    }

    public event Action onDoorwayTriggerEnter2;

    public void DoorwayTriggerEnter2()
    {
        if (onDoorwayTriggerEnter2 != null)
        {
            onDoorwayTriggerEnter2();
        }
    }
}
