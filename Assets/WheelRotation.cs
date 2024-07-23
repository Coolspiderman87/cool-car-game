using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour {
	public float rotationSpeed = 5f;
	Transform parentCar;
	// Use this for initialization
	void Start () {
		parentCar = transform.parent;
	}
	
	// Update is called once per frame
	void Update () {
		var velocity = parentCar.GetComponent <Rigidbody> ().velocity;
		float speed = velocity.z < 0? -velocity.magnitude:velocity.magnitude;
		transform.Rotate (Vector3.right, rotationSpeed * speed * Time.deltaTime);
	}
}
