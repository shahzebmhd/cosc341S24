using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;
    public TextAlignment scoreText;
    private int score = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();  
    }
    public void AddScore(int amount) {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText() {
        scoreText.SetText("Score: {0}", score);
    }
}
