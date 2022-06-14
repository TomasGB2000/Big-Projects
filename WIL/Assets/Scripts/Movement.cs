using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public GameObject soundManager;
    private SoundManager _soundScript;
    public GameObject gameManger;
    private GameManager _gameManager;

    public float speed = 5f;

    Rigidbody2D playerBody;

    // Start is called before the first frame update
    public void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        _soundScript = soundManager.GetComponent<SoundManager>();
    }

    // Update is called once per frame
    public void Update()
    {
        UserInput();
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
}
