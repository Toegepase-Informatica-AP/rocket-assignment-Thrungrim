using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Collected : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            score = int.Parse(scoreText.text);
            UpdateScore(1);

        }
    }
    private void UpdateScore(int scoreToAdd)
    {

        score += scoreToAdd;
        scoreText.text = score.ToString();
    }
}
