using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public paddle paddle;
	
	private Vector3 paddleToBallVector;
	private bool hasLaunched;

	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
		hasLaunched = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasLaunched)
		{
		// we are waiting on the game to start
		//	keep the ball locked to the paddle position
			this.transform.position = (paddle.transform.position + paddleToBallVector);
			
			if (Input.GetMouseButtonDown(0))
			{
				// the player has started the game
				//	launch the ball
				hasLaunched = true;
				this.rigidbody2D.velocity = new Vector2(2f, 10f);
			}
		}
		
		
	}
}
