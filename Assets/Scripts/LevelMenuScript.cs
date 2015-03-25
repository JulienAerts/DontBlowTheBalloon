using UnityEngine;
using System.Collections;

public class LevelMenuScript : MonoBehaviour {

	public void OnClickPlay(){
		Application.LoadLevel("Level1");
	}

	public void OnClickInfini(){
		Application.LoadLevel ("LevelInfini");
	}

	public void Retour() 
	{
		Application.LoadLevel ("MainMenu");
	}

}
