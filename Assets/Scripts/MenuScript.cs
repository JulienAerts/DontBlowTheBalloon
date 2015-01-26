using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public void OnClickPlay(){
	    Application.LoadLevel("LevelMenu");
	}
	public void OnClickOption(){

	}
	public void OnClickExit(){
		Application.Quit();	
	}

}
