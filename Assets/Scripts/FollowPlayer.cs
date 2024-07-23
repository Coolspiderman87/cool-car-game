using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	//referend to the player position
	public Transform player;
	public Vector3 offset;

	//Update is called once per frame
	void Update () {
		//set to cam position to player position
		transform.position = player.position + offset;
	}
}
