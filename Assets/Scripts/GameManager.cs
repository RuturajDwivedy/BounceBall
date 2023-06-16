using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score;
    public Text scoreText;
    private void Awake()
    {
        instance = this;
    }

    public void Restart()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
