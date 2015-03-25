using UnityEngine;
using System.Collections;

public class MusicSourceScript : MonoBehaviour {

	static bool AudioBegin = false;
	GameObject otherSound;
	void Update()
	{
		if (Application.loadedLevelName == "LevelMenu") {
			Destroy (this.gameObject);
		} 
		else 
		{
			DontDestroyOnLoad (this.gameObject);
		}

	}
	void Awake()
	{
		otherSound = GameObject.FindGameObjectWithTag("Game Music");
		
		if (otherSound == this.gameObject)
		{
			if (!AudioBegin)
			{
				DontDestroyOnLoad(this.gameObject);
				AudioBegin = true;
			}
		}
		else
		{
			Destroy(this.gameObject);
		}
	
		
	}



}

