using UnityEngine;

public class PlayerCarMovement : MonoBehaviour {

	//variables
	public float forceApplied = 20f; //force added to the player
	public Rigidbody rb;
	public float forwardForce = 1000f;

	// Update is called one per physics update
	void FixedUpdate () {
		//what key did the user press? 
		//moves forward
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		//move right (x direction positive)
		if (Input.GetKey ("d")) {
			rb.AddForce (forceApplied * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		//move left (x direction negative)
		if (Input.GetKey ("a")) {
			rb.AddForce (-forceApplied * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
	}		
}
