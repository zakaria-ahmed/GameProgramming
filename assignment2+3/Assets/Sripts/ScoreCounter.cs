using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public GameObject scoreText;

    public static int scoreValue;



    void Update()
    {
        scoreText.GetComponent<Text>().text = "Your Powerup SCORE is: " + scoreValue;
    }
}
