using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBall : MonoBehaviour
{

    public static int theBallScore;

    void OnTriggerEnter(Collider other)
    {
        ScoringSystem2.theBallScore += 1;
        Destroy(gameObject);
    }
}
