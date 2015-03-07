using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour{

	public int startingHealth = 1;
	public int currentHealth;
	public bool isDead = false;
	void Start() 
	{
		ObstacleBlocs.speed = 4f;
		currentHealth = startingHealth;
		if (Physics2D.gravity.y > 0) 
		{
			Physics2D.gravity *= -1;
		}
	}

	void Update()
	{
		Gravity ();
	}

	void Gravity()
	{
		if (Input.GetButtonDown ("Fire1")) 
		{
			ScoreManager.score++;
			Physics2D.gravity *= -1;
		}
	}

	public void Death()
	{
		isDead = true;
		currentHealth = 0;
		ObstacleBlocs.speed = 0f;
	}
}
