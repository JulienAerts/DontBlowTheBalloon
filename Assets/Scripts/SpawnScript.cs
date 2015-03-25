using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] prefabBlocs;

	void Start () {
		Spawn ();
	}
	
	void Spawn()
	{
		Instantiate (prefabBlocs [Random.Range (0, prefabBlocs.Length)]);
		Invoke ("Spawn", 2f);
	}
}
