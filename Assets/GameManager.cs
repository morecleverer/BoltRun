using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float level(int score)
    {
        int defaultSpeed = -6;
        int increSpeed = (score * -1) / 100;
        if (increSpeed < -6)
            increSpeed = -6;

        return defaultSpeed + increSpeed;
    }
    
}
