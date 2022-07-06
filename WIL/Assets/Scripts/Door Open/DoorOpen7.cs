using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen7 : MonoBehaviour
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
        GameEvents7.current.onDoorwayTriggerEnter7 += OnDoorwayOpen7;
    }

    private void OnDoorwayOpen7()
    {
        Destroy(gameObject);
    }
}
