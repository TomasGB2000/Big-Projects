using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen3 : MonoBehaviour
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
        GameEvents3.current.onDoorwayTriggerEnter3 += OnDoorwayOpen3;
    }

    private void OnDoorwayOpen3()
    {
        Destroy(gameObject);
    }
}
