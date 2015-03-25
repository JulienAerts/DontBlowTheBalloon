using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManagerInfini : MonoBehaviour
{
	public static float scoreInfini = 0;	
	Text text;
	public PlayerScript playerHealth;

	void Awake ()
	{
		scoreInfini = 0;
		text = GetComponent <Text> ();
	}
	
	
	void Update ()
	{
		if (playerHealth.currentHealth > 0) {
			scoreInfini += Time.deltaTime;
			text.text = "Score: " + (int)(scoreInfini * 10);
		}
	}
}