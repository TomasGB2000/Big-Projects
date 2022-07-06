using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen4 : MonoBehaviour
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
        GameEvents4.current.onDoorwayTriggerEnter4 += OnDoorwayOpen4;
    }

    private void OnDoorwayOpen4()
    {
        Destroy(gameObject);
    }
}
