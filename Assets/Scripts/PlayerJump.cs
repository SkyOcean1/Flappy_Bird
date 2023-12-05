using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
    public GameObject soundManager; //게임오브젝트 형태의 사운드매니저를 유니티 에디터상에서 받아오기 

    Rigidbody2D rb; // Rigidbody2D 형태의 변수 rb선언
    float power = 11.5f;
    void Start()
    {
        soundManager = GameObject.Find("SoundManager");
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // 마우스 왼쪽버튼 클릭시 이벤트 발생
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
