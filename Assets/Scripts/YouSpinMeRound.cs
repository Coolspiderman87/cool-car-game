using UnityEngine;

public class YouSpinMeRound : MonoBehaviour {
	public float RotationSpeed = 20f;

	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * RotationSpeed * Time.deltaTime);
		
	}
}
