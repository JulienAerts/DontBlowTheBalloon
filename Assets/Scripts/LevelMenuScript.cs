using UnityEngine;
using System.Collections;

public class LevelMenuScript : MonoBehaviour {

	public void OnClickPlay(){
		Application.LoadLevel("Level1");
	}
}
