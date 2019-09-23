using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float currentTime = 0f;
    float startTime = 10F;

    [SerializeField] Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("00.00");

        if (currentTime <= 0)
        {
            countdownText.text = currentTime.ToString("TIMES UP! Try again");
        }
    }
}
