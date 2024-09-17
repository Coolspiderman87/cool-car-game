using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class NOSBar : MonoBehaviour {
	public Slider BoostBar;
	public float MaxBoostTime = 2.9f;
	private float CurrentBoostTime;
	public MSVehicleControllerFree Player;
	[Range(0.0f, 0.5f)][Tooltip("How much the camera shakes when the vehicle is boosting.")]
	public float boostTremor = 0.2f;
	private float StartingFOV;
	public float BoostFOV = 90;
	public float FOVChangeSpeed = 0.2f;
	private float FOVChangeTime = 0;
	public Image BoostReplenish;
	private float StartingVignette;
	public PostProcessVolume PPV;
	public float VignetteChangeSpeed = 0.2f;
	private float VignetteChangeTime = 0f;
	private Vignette VignetteLayer;
	public float BoostVignette = 1.0f;
	public List<GameObject> TailLightTrails;
	private float TailLightOpacity = 1f;
	public AudioSource audiosource;
	public AudioClip audiostartWindSFX;
	public AudioClip audiostartBoostSFX;
	private GameObject[] cameras;
    private void Awake() {
    
        cameras = GameObject.FindGameObjectsWithTag("MainCamera");
    }


    void Start () {
		CurrentBoostTime = MaxBoostTime;
		//Cam = Camera.main;
		//Cam = GameObject.Find("Camera1").GetComponent<Camera>();
		StartingFOV = Camera.main.fieldOfView;
		PPV.profile.TryGetSettings (out VignetteLayer);
		StartingVignette = VignetteLayer.intensity.value;


	}
	
	// Update is called once per frame
	void Update () { 
		if (Input.GetKeyDown (KeyCode.LeftShift) && CurrentBoostTime > MaxBoostTime/3) {
			StopCoroutine (BeginBoostSFX ());
			StartCoroutine (BeginBoostSFX ());
		}
		if (Input.GetKey (KeyCode.LeftShift) && CurrentBoostTime > MaxBoostTime/3) {
			Player.isBoosting = true;


		}
		if (Input.GetKeyUp (KeyCode.LeftShift) || CurrentBoostTime <= 0) {
			StopCoroutine (BeginBoostSFX ());
			Player.isBoosting = false;
			audiosource.Stop ();
		}
		if (Player.isBoosting == true) {
			TailLightOpacity = 1f;
			foreach (var tailLight in TailLightTrails) { 
				tailLight.GetComponentInChildren<TrailRenderer>().time = TailLightOpacity;
				tailLight.SetActive (true);
            }
			FOVChangeTime += FOVChangeSpeed * Time.deltaTime;
			VignetteChangeTime += VignetteChangeSpeed * Time.deltaTime;
			CurrentBoostTime -= Time.deltaTime;
			BoostBar.value = CurrentBoostTime / MaxBoostTime;
			Player.DoCameraShake (boostTremor);
			float bluramount = Mathf.Min (1f-CurrentBoostTime / MaxBoostTime, 0.75f);
			foreach (GameObject cam in cameras) {
				if (cam.activeInHierarchy) {
					cam.GetComponent <MotionBlur> ().blurAmount = bluramount;
				} 
			}
		} else {
			foreach (GameObject cam in cameras) {
				if (cam.activeInHierarchy) {
					cam.GetComponent <MotionBlur> ().blurAmount = 0f;
				} 
			}
			if (TailLightOpacity > 0) {
				TailLightOpacity -= Time.deltaTime; 
			} else {
				TailLightTrails.ForEach (T => T.SetActive(false));
			
			}
			TailLightTrails.ForEach(T => T.GetComponentInChildren<TrailRenderer>().time = TailLightOpacity);

			FOVChangeTime -= FOVChangeSpeed * Time.deltaTime;
			VignetteChangeTime -= VignetteChangeSpeed * Time.deltaTime;
			BoostReplenish.color = new Color (246/255f, 250/255f, 10/255f);
			CurrentBoostTime += Time.deltaTime;
			if (CurrentBoostTime >= MaxBoostTime / 3) {
				BoostReplenish.color = new Color (68/255f, 216/255f, 255/255f);
			}
			if (CurrentBoostTime >= MaxBoostTime) {
				CurrentBoostTime = MaxBoostTime;
			}
			BoostBar.value = CurrentBoostTime  / MaxBoostTime;
		}
		FOVChangeTime = Mathf.Clamp01 (FOVChangeTime);
		VignetteChangeTime = Mathf.Clamp01 (VignetteChangeTime);
		VignetteLayer.intensity.value = Mathf.Lerp (StartingVignette, BoostVignette, VignetteChangeTime);
		Camera.main.fieldOfView = Mathf.Lerp (StartingFOV, BoostFOV, FOVChangeTime);
	}
	private IEnumerator BeginBoostSFX () {
		audiosource.loop = false;
		audiosource.clip = audiostartBoostSFX;
		audiosource.Play ();
		while (audiosource.isPlaying)
			yield return null;
		audiosource.loop = true;
		audiosource.clip = audiostartWindSFX;
		audiosource.Play ();
			
	}
}