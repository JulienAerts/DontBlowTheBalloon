using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	GameObject boutonRetour;

	void Start()
	{
		boutonRetour = GameObject.Find ("Retour");
	}

	public void OnClickPlay(){
	    Application.LoadLevel("LevelMenu");
	}
	public void OnClickExit(){
		Application.Quit();	
	}

	public void Options()
	{
		boutonRetour.active = true;
	}

	public void Retour()
	{
		boutonRetour.active = false;
	}

}
