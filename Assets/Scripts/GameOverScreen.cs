using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    public void Setup()
    {
        gameObject.SetActive(true);
        pointsText.text = "Score Points";
    }

    public void RestartButton() {
        SceneManager.LoadScene("Tetris");
    }

    public void ExitButton() {
        SceneManager.LoadScene("MainMenu");
    }
}
