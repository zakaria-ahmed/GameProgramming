using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMyGame : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("CarScene");
    }
}
