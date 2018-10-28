using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishedLine : MonoBehaviour {
    public PlayerController playerController;
    public Text victoryLine;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Finish")
        {
            playerController.enabled = false;
            victoryLine.text = "GAME CLEAR!";
        }
    }
}
