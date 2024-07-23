using UnityEngine;

public class PlayerCollision : MonoBehaviour {
	public Rigidbody rb;

	//get a reference to movement script
	public MSVehicleControllerFree movement;

	void Update (){

		if (rb.position.y < -1f)
			GoToLastCheckpoint ();

	}

//	//fires whenever collision happens
//	void OnCollisionEnter(Collision collisionInfo){
//		//fire some script only when the player hits an obstacle
//		if(collisionInfo.collider.tag == "Obstacle"){
//			//stop player movement
//			movement.enabled = false;
//			FindObjectOfType<GameManager> ().EndGame ();
//		}	
//	}
	private void GoToLastCheckpoint(){
		var cp = FindObjectOfType<GameManager> ().GetCheckpoint();
		transform.SetPositionAndRotation (cp.position, cp.rotation);
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
	}
	private void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Checkpoint")) {
			FindObjectOfType<GameManager> ().SetCheckpoint (other.transform);
		}
	}
}
