using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Text scoreText;
    public PlayerSo player;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "SCORE: " + player.playerScore.ToString();
    }

}
