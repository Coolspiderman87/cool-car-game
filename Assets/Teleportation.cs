using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour {
	public Transform TeleportDestination;
	void OnTriggerEnter(Collider other){
		Debug.Log (other.gameObject.name);
		if (other.gameObject.tag != "Player")
			return;
		other.transform.position = TeleportDestination.position;
	}
}
