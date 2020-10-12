using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOverCanvas;
    public GameObject playingCanvas;
    public GameObject winnerCanvas;
    private Health healthPlayer;

    public enum GameStates
    {
        Playing,
        GameOver,
        Winner
    }

    public GameStates gameState = GameStates.Playing;

    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.SetActive(false);
        winnerCanvas.SetActive(false);
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        healthPlayer = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameStates.Playing:
                if (!healthPlayer.isAlive)
                {
                    gameState = GameStates.GameOver;
                    playingCanvas.SetActive(false);
                    winnerCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
                }
                break;
            case GameStates.GameOver:
                break;
            default:
                break;
        }
    }
}
