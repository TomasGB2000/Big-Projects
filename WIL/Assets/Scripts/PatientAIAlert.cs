using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientAIAlert : MonoBehaviour
{
    /***************************************************************************************
* Title: Stealth
* Author: BlackThornProd
* Date: 2018
* Code version: N/A
* Availability: https://www.youtube.com/watch?v=GPrGg8UDB_E
***************************************************************************************/
    public float rotationSpeed;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.queriesStartInColliders = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance);
        if (hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
        }

        if (hitInfo.collider.CompareTag("Player"))
        {
            //Instantiate<Circle>();
        }

        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
        }
    }
}
