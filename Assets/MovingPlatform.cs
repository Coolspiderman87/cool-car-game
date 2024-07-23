using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
	public Transform UpperLimit;
	public Transform LowerLimit;
	private Vector3 UpperPosition;
	private Vector3 LowerPosition;
	public float Speed = 1;

	// Use this for initialization
	void Start () {		
		UpperPosition = UpperLimit.position;
		LowerPosition = LowerLimit.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var t = Mathf.PingPong (Time.time * Speed, 1);
		transform.position = Vector3.Lerp (UpperPosition, LowerPosition, t);
	}
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			other.transform.parent = transform;
		}
	}
	void OnTriggerExit (Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			if (other.transform.parent == transform) {
				other.transform.parent = null;
			}
		}
	}
}
