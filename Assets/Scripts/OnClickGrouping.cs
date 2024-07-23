using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickGrouping : MonoBehaviour {

	public void BackToMenu(){
		SceneManager.LoadScene(0);
	}
	public void PlayTheGame(){
		SceneManager.LoadScene(1);
	}
	public void Garage(){
		SceneManager.LoadScene(3);
	}
	public void TheTuningsSsSshop(){
		SceneManager.LoadScene(4);
	}
	public void HowDoIPlayAAAAAA(){
		SceneManager.LoadScene(5);
	}
	public void SelectLevel(){
		SceneManager.LoadScene(6);
	}
}