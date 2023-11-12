using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highscoreText;

    int score = 10;
    int highscore = 0;

    private void Awake() {
    instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
      scoreText.text = "Score: " + score.ToString();
      highscoreText.text = "Highscore: " + highscore.ToString();






    }

        public void RemovePoint() {

            score -= 1;
            scoreText.text = "Score: " + score.ToString();
            if (highscore < score)
                PlayerPrefs.SetInt("highscore", score);
        }

  
}
