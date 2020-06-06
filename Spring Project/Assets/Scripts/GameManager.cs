using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive = true;
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        isGameActive = true;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        updateScore();
        scoreText.text = "Score: " + score;
    }

    void updateScore()
    {
        score = (int)Time.time * 10;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
