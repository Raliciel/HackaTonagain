using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;
    public Transform Respanw;
	public float movingForce = 500f;

    private void Start()
    {
        transform.position = Respanw.position;
        transform.rotation = Random.rotation;
    }

    void FixedUpdate () {
		if ( Input.GetKey("right") ) 
		{
			rb.AddForce(movingForce * Time.deltaTime, 0, 0);
		}
		if ( Input.GetKey("left") ) 
		{
			rb.AddForce(-movingForce * Time.deltaTime, 0, 0);
		}
        if ( Input.GetKey("up"))
        {
            rb.AddForce(0, 0, movingForce * Time.deltaTime);
        }
        if (Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -movingForce * Time.deltaTime);
        }
    }
}
