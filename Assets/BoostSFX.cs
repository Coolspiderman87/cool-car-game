using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSFX : MonoBehaviour {
	public MSVehicleControllerFree Player;
	public AudioSource audiosource;
	public AudioClip audiostartWindSFX;
	public AudioClip audiostartBoostSFX;
	public AudioClip audioScreechSFX;
	// Use this for initialization :)
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.isBoosting) {
			audiosource.clip = audiostartBoostSFX;
			if (!audiosource.isPlaying) {
				audiosource.Play ();
			}
		} 
		else if(Player.isBraking) {
            audiosource.clip = audioScreechSFX;
            if (!audiosource.isPlaying)
            {
                audiosource.Play();
            }
        }
		else {
			audiosource.Stop ();
		}
			
	}
	private IEnumerator BeginBoostSFX () {
		audiosource.loop = false;
		audiosource.clip = audiostartBoostSFX;
		audiosource.Play ();
		while (audiosource.isPlaying)
			yield return null;
		audiosource.loop = false;
		audiosource.clip = audiostartWindSFX;
		audiosource.Play ();
	}
}