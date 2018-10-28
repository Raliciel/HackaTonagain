using UnityEngine;

public class CoinSpinning : MonoBehaviour {
    public float spinSpeed = 10f;
	void Update () {
        transform.Rotate(Vector3.right, Time.deltaTime * spinSpeed);
	}
}
