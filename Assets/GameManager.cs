using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
	public GameObject CheckpointPanel;

//	public void EndGame(){
//		if (gameHasEnded == false) {
//			gameHasEnded = true;
//			Debug.Log ("Game Over");
//			Invoke ("Restart", 1f);
//		}
//	}
	private Transform LastCheckpoint;
	public void SetCheckpoint(Transform NewCheckpoint){
		CheckpointPanel.SetActive (true);
		StartCoroutine (hidePanel ());
		LastCheckpoint = NewCheckpoint;
	}
	IEnumerator hidePanel(){
		yield return new WaitForSeconds (4);
		CheckpointPanel.SetActive (false);
	}
	public Transform GetCheckpoint(){
		return LastCheckpoint;
	}

	void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

}
