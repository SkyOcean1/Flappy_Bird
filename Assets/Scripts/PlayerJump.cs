using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
    public GameObject soundManager; //���ӿ�����Ʈ ������ ����Ŵ����� ����Ƽ �����ͻ󿡼� �޾ƿ��� 

    Rigidbody2D rb; // Rigidbody2D ������ ���� rb����
    float power = 11.5f;
    void Start()
    {
        soundManager = GameObject.Find("SoundManager");
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // ���콺 ���ʹ�ư Ŭ���� �̺�Ʈ �߻�
        {
            rb.velocity = Vector2.up * power;
            soundManager.GetComponent<SoundManager>().SoundPlay("JUMP");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // SceneManager.LoadScene("Gamceover");
        power = 0.0f;
        StartCoroutine(GameOver());
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(3.0f);
        //soundManager.GetComponent<SoundManager>().SoundPlay("DIE");
        SceneManager.LoadScene("MenuScene");
    }
}
