using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour{

	Animator anim;
	GameObject rope;
	RopeScript ropeDestroy;
	public int startingHealth = 1;
	public int currentHealth;
	public float speed =  100f;
	public bool isDead = false;
	public bool rotLeft = true;
	public bool rotRight = false;
	void Start() 
	{
		rope = GameObject.FindGameObjectWithTag ("Rope");
		ropeDestroy = rope.GetComponent<RopeScript> ();
		anim = GetComponent<Animator> ();
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
		RotateUpDown ();

	}

	void Gravity()
	{

		if (Input.GetButtonDown ("Fire1")) 
		{
			ScoreManager.score++;
			Physics2D.gravity *= -1;
			if (rotLeft) {
				rotLeft = false;
				rotRight = true;
			}else{
				rotLeft = true;
				rotRight = false;
			}
		}
	}
	void RotateUpDown()
	{
		var dir = rigidbody2D.velocity;
		var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		var q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, q, speed * Time.deltaTime);

	}
	public void Death()
	{
		anim.SetTrigger ("Explode");
		ropeDestroy.DestroyRope ();
		isDead = true;
		currentHealth = 0;
		ObstacleBlocs.speed = 0f;
		rigidbody2D.isKinematic = true;
	}


}
