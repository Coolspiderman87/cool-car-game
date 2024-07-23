using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Checkpoint{
	Tutorial, Easy, Medium, Hard, Difficult, Insane, QmQmQm
}
[CreateAssetMenu(fileName = "NewCheckPointData", menuName = "CheckPointData")]
public class CheckpointData : ScriptableObject {
	public List<Vector3> Checkpoints;
	public Transform LastCheckpoint;
	public Checkpoint Selected;

	public Vector3 GetPosition(Checkpoint Cp){
		return Checkpoints [(int)Cp];
	} 
}
