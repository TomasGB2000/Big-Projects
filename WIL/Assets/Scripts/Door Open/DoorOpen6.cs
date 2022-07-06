using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen6 : MonoBehaviour
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
        GameEvents6.current.onDoorwayTriggerEnter6 += OnDoorwayOpen6;
    }

    private void OnDoorwayOpen6()
    {
        Destroy(gameObject);
    }
}
