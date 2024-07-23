using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoorRemote : MonoBehaviour {
	public Animator anim;
	public void OpenGarageDoor (){
		anim.SetTrigger ("GarageDoorOpen");
		}	
		public void CloseGarageDoor (){
		anim.SetTrigger ("GarageDoorClose");
	}
}