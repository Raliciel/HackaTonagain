using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroy : MonoBehaviour {
    //for destroy self when touched by Player
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player") ;
        Destroy(this.gameObject);
    }
}
