using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText; //how the text is linked to the script

    // Start is called before the first frame update
    void Start()
    {
        score = 0; //making the score start at 0
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score; //updating the score
    }
}
