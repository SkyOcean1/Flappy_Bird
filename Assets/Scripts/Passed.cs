using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passed : MonoBehaviour
{
    [SerializeField]
    GameManager gameManager;

    GameObject soundManager;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        soundManager = GameObject.Find("Sound Manager");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        soundManager.GetComponent<SoundManager>().SoundPlay("PASS");
        gameManager.GetComponent<GameManager>().SetScore();
    }
}
