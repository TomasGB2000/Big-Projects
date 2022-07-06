using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float dirX;
    public GameObject soundManager;
    private SoundManager _soundScript;
    public GameObject gameManger;
    private GameManager _gameManager;
    private SpriteRenderer sprite;
    private bool canHide = false;
    private bool hiding = false;

    public float speed = 5f;

    Rigidbody2D playerBody;

    // Start is called before the first frame update
    public void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        playerBody = GetComponent<Rigidbody2D>();
        _soundScript = soundManager.GetComponent<SoundManager>();
    }

    // Update is called once per frame
    public void Update()
    {
        UserInput();

        if (canHide && Input.GetKey(KeyCode.Space))
        {
            Physics2D.IgnoreLayerCollision(8, 9, true);
            sprite.sortingOrder = 0;
            hiding = true;
        }
    }

    public void FixedUpdate()
    {
        if (!hiding)
        {
            playerBody.velocity = new Vector2(dirX, playerBody.velocity.y);
        }
        else
        {
            playerBody.velocity = Vector2.zero;
        }
    }

    public void UserInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        } 
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Hiding"))
        {
            canHide = true;
        }
        if (other.gameObject.tag =="Key")
        {
            Destroy(other.gameObject);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Hiding"))
        {
            canHide = false;
        }
    }
}
