using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

	public float ShakeDuration = 0.5f;
	public float ShakeMagnitude = 0.5f;
	private Vector3 OriginalPosition;
	private bool isShaking = false;

	void Start(){
	}

	public void StartScreenShake (){
		if (isShaking)
			return;
		OriginalPosition = transform.localPosition;
		if (!gameObject.activeSelf)
			return;
		Debug.Log (OriginalPosition.z);
		StartCoroutine (Shake());
	}
	public void StopScreenShake (){
		StopAllCoroutines ();
		isShaking = false;
		transform.localPosition = OriginalPosition;
	}
	IEnumerator Shake (){
		isShaking = true; 
		var time = 0.0f;
		while (time < ShakeDuration) {
			var x = Random.Range (-1f, 1f) * ShakeMagnitude;
			var y = Random.Range(-1f, 1f) * ShakeMagnitude;

			transform.localPosition = new Vector3 (x, y, OriginalPosition.z);
			time += Time.deltaTime;
			yield return null;
		}
		transform.localPosition = OriginalPosition;
		isShaking = false;
	}
}
