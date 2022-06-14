using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientAIAlert : MonoBehaviour
{
    /***************************************************************************************
* Title: Unity 5 - How To Spawn Objects Using a Trigger
* Author: Lurony
* Date: 2016
* Code version: N/A
* Availability: youtube.com/watch?v=_Xrw2EEhzI4
***************************************************************************************/
    public Transform spawnpoint;
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.queriesStartInColliders = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(Prefab, spawnpoint.position, spawnpoint.rotation);
        }
    }
}
