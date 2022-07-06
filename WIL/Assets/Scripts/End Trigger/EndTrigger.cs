using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject soundManager;
    private SoundManager _soundScript;

    void Start()
    {
        _soundScript = soundManager.GetComponent<SoundManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("PublicFloor2");
    }
}
