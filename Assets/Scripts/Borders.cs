using UnityEngine;
using System.Collections;

public class Borders : MonoBehaviour {

	PlayerScript playerDamage;
	GameObject player;

	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		playerDamage = player.GetComponent<PlayerScript> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player" && !playerDamage.isDead) 
		{
			player.audio.Play();
			playerDamage.Death();
			
			//	Application.LoadLevel("LevelMenu");
		}
	}
}
