using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;

    void Start()
    {
        DisplayScore();
    }

    public void UpdateScore()
    {
        score++;
        DisplayScore();
    }

    void DisplayScore()
    {
        GameObject.Find("/Canvas/Score").GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();
    }
}
