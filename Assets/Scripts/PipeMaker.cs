using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMaker : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0.0f;

    void Start()
    {
        GameObject newPipe = Instantiate(pipe); // pip ������Ʈ�� �ν��Ͻ�ȭ(��üȭ) �Ͽ� newPipe�� ����
        newPipe.transform.position = new Vector3(0, Random.Range(-3.2f, 1.2f), 0.0f);
        Destroy(newPipe, 6.0f); // ���� �ð� �Ŀ� �������� �������� ��ɹ�
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1.2f) 
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(0, Random.Range(-3.2f, 1.2f), 0.0f);
            Destroy(newPipe, 6.0f);
            timer = 0.0f;
        }
    }
}
