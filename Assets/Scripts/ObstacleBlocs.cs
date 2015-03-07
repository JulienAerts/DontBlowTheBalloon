using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObstacleBlocs : MonoBehaviour {

	public static float speed = 4f;
	PlayerScript playerDamage;
	GameObject player;

	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		playerDamage = player.GetComponent<PlayerScript> ();
	}

	void Update () {
		Movement ();
	}

	void Movement()
	{
		transform.Translate(Vector2.right * -speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player" && !playerDamage.isDead) 
		{
			playerDamage.Death();
		//	Application.LoadLevel("LevelMenu");
		}
	}
}
