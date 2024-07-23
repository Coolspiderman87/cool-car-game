using UnityEngine;

public class Music : MonoBehaviour {
	public static Music Instance;
	void Awake(){
		if (Instance == null) {
			Instance = this;
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (gameObject);
		}
	}
}
