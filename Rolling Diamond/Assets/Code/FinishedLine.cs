using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishedLine : MonoBehaviour {
    public PlayerController playerController;
    public Text victoryLine;
    public Score score;
    public GameObject finishMenu;

    public void Start()
    {
        finishMenu.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Finish")
        {
            finishMenu.SetActive(true);
            playerController.enabled = false;
            if (score.scoreReal >= 5)
            {
                victoryLine.text = "GAME CLEAR!";
            }
            else {
                victoryLine.text = "COLLECT 5 COINS!!";
                victoryLine.fontSize = 50;
            }
        }
    }
}
