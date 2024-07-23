using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSwitcharoo : MonoBehaviour {
	public List<GameObject> Vehicles;

	private void Start()
	{
		ChooseCar(1);
	}

	public void ChooseCar(int num)
	{
		Debug.Log("CarChoose");
		Vehicles.ForEach(v => v.SetActive(false));
		Vehicles[num - 1].SetActive(true);
	}
}
	