using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour {

	public PlayerScript playerHealth;

	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerHealth.currentHealth <= 0) 
		{
			GameOver ();
		}
	}

	public void GameOver () {
		anim.SetTrigger ("GameOver");
	}

}
