using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerEnter2D(Collider2D collider){
		print("Trigger");
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		// player lost. Load lose screen
		levelManager.LoadLevel("lose");
	}
}
