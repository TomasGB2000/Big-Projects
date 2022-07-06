using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents3 : MonoBehaviour
{
    /***************************************************************************************
* Title: Events
* Author: Game Dev Guide
* Date: 2019
* Code version: N/A
* Availability: https://www.youtube.com/watch?v=gx0Lt4tCDE0
***************************************************************************************/

    public static GameEvents3 current;

    private void Awake()
    {
        current = this;
    }

    public event Action onDoorwayTriggerEnter3;

    public void DoorwayTriggerEnter3()
    {
        if (onDoorwayTriggerEnter3 != null)
        {
            onDoorwayTriggerEnter3();
        }
    }
}
