using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleBlock : MonoBehaviour {
	private MeshRenderer Rend;
	public float InvisibleTime = 5f;
	public float VisibleTime = 0.5f;
	// Use this for initialization
	void Start () {
		Rend = GetComponent<MeshRenderer> ();
		StartCoroutine (DisappearReappear ());
	}
	
	// Update is called once per frame
	IEnumerator DisappearReappear () {
		while (true) {
			yield return new WaitForSeconds (VisibleTime);
			Rend.enabled = false;
			yield return new WaitForSeconds (InvisibleTime);
			Rend.enabled = true;
		}
	}
}
