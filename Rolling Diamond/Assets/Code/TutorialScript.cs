using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour {
    public PlayerController playerController;
    public Text tutorialText;
    public Score score;
	void Start () {
        tutorialText.enabled = false;
	}

	void OnCollisionEnter (Collision player) {
        if (player.collider.tag == "Floor")
        {
            tutorialText.enabled = true;
            if (Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right"))
            {
                tutorialText.text = "Great!\nNow Try to find coins and collect 5 of them.";
                if (score.scoreReal == 5)
                {
                    tutorialText.text = "Cool!\n Now find White Button.";

                }
            }
        }
        if (score.scoreReal == 5 && player.collider.tag == "Finish")
                    {
                        tutorialText.text = "You have complete Tutorial Level!\n You should try another Level in Select Menu.";
                    }
	}
}
