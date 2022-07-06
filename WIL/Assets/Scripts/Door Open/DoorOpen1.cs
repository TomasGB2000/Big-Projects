using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen1 : MonoBehaviour
{
    /***************************************************************************************
* Title: Events
* Author: Game Dev Guide
* Date: 2019
* Code version: N/A
* Availability: https://www.youtube.com/watch?v=gx0Lt4tCDE0
***************************************************************************************/

    private void Start()
    {
        GameEvents1.current.onDoorwayTriggerEnter1 += OnDoorwayOpen1;
    }

    private void OnDoorwayOpen1()
    {
        Destroy(gameObject);
    }
}
