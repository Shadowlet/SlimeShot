using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    public int currentScore;

    Text score;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;

        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        currentScore++;
        score.text = "Score: " + currentScore;
        Debug.Log("SCORE: " + currentScore);
    }
}
