using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseAI : MonoBehaviour
{
    public float speed = 3f;
    Transform target;
    void Start()
    {
        
    }

    void Update()
    {
        if (target != null)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target = other.transform;
        }

        if (other.gameObject.tag == "Keys")
        {
            target = other.transform;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target = null;
        }

        if (other.gameObject.tag == "Keys")
        {
            target = null;
        }
    }
}
