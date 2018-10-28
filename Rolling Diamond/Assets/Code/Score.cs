using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private int scoreReal = 0;
    public Text scoreCount;

	// Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Coin" )
        {
            scoreReal++;
        }
    }
    // Update is called once per frame
    void Update () {
        scoreCount.text = "Score: " + scoreReal;
    }
}
