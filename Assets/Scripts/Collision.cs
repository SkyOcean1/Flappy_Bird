using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    GameObject soundManager;
    void Start()
    {
        //soundManager �ʱ�ȭ
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �׾��ٴ� ���� ȿ�� �÷���
        if (collision.gameObject.tag == "player")
        soundManager.GetComponent<SoundManager>().SoundPlay("DIE");
        // ���� ó��
    }
}
