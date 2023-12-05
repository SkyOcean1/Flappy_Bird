using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score = 0;
    int bestScore = 0;

    [SerializeField]
    TextMeshProUGUI scoreText;

    void Awake()
    {
        var managerCnt = FindObjectsOfType<GameManager>();
        DontDestroyOnLoad(gameObject);

        if (managerCnt != null && managerCnt.Length == 1)
        {
            DontDestroyOnLoad (gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        scoreText.text = "Score : " + score.ToString();
    }

    public void SetScore()
    {
        score++;
        if (score > bestScore)
        {
            bestScore = score;
        }
    }

    public int GetScore()
    {
        return score;
    }

    public int GetBestScore()
    {
        return bestScore;
    }
}
