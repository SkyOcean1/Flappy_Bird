using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMaker : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0.0f;

    void Start()
    {
        GameObject newPipe = Instantiate(pipe); // pip 오브젝트를 인스턴스화(실체화) 하여 newPipe로 생성
        newPipe.transform.position = new Vector3(0, Random.Range(-3.2f, 1.2f), 0.0f);
        Destroy(newPipe, 6.0f); // 일정 시간 후에 파이프가 없어지는 명령문
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
