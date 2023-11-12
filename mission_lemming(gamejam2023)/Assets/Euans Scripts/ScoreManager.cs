using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public Text highscoreText;

    int score = 10;
    int highscore = 0;
    // Start is called before the first frame update
    void Start()
    {
      scoreText.text = "Score: " + score.ToString();
      highscoreText.text = "Highscore: " + highscore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}