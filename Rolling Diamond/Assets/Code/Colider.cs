using UnityEngine;

public class Colider : MonoBehaviour {

    public PlayerController playerController;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            playerController.enabled = false;
        }
    }

}
