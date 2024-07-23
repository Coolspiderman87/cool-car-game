using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	//get the z position of the player
	public Transform player;
	//get the UI text
	public Text scoreText;

	public Transform StartingLine;
	
	// Update is called once per frame
	void Update () {
		var distance = Vector3.Distance (StartingLine.position, player.position);
		//update the score text with the z position of the player
		scoreText.text = distance.ToString("0");
	}
}
