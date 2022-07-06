using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents7 : MonoBehaviour
{
    /***************************************************************************************
* Title: Events
* Author: Game Dev Guide
* Date: 2019
* Code version: N/A
* Availability: https://www.youtube.com/watch?v=gx0Lt4tCDE0
***************************************************************************************/

    public static GameEvents7 current;

    private void Awake()
    {
        current = this;
    }

    public event Action onDoorwayTriggerEnter7;

    public void DoorwayTriggerEnter7()
    {
        if (onDoorwayTriggerEnter7 != null)
        {
            onDoorwayTriggerEnter7();
        }
    }
}
