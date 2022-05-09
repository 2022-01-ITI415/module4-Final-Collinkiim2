using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem2 : MonoBehaviour
{

    public GameObject scoreTextBall;
    public static int theBallScore;

    void Update()
    {
        scoreTextBall.GetComponent<Text>().text = "RedBalls: " + theBallScore;

    }

}
