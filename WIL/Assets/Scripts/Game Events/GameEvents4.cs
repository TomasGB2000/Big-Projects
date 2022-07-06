using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents4 : MonoBehaviour
{
    /***************************************************************************************
* Title: Events
* Author: Game Dev Guide
* Date: 2019
* Code version: N/A
* Availability: https://www.youtube.com/watch?v=gx0Lt4tCDE0
***************************************************************************************/

    public static GameEvents4 current;

    private void Awake()
    {
        current = this;
    }

    public event Action onDoorwayTriggerEnter4;

    public void DoorwayTriggerEnter4()
    {
        if (onDoorwayTriggerEnter4 != null)
        {
            onDoorwayTriggerEnter4();
        }
    }
}
