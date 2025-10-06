using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(true);

        if (GameManager.Instance)
        {
            scoreText.text = "Score: " + GameManager.Instance.score;
        }

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
