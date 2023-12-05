using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    GameObject soundManager;
    void Start()
    {
        //soundManager 초기화
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 죽었다는 사운드 효과 플레이
        if (collision.gameObject.tag == "player")
        soundManager.GetComponent<SoundManager>().SoundPlay("DIE");
        // 죽음 처리
    }
}
