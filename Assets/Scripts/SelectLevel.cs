using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour {
	public CheckpointData CpData;
	public Checkpoint Cp;
	public void Selectlevel() {
		CpData.Selected = Cp;
		SceneManager.LoadScene("Main Scene");
	}

}
