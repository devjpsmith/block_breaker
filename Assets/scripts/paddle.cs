using UnityEngine;
using System.Collections;

public class paddle : MonoBehaviour {
	const float X_MAX = 15.5f;
	const float X_MIN = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float mousePosInBlocks = (Input.mousePosition.x / Screen.width) * 16;
		
		if (mousePosInBlocks > X_MIN && mousePosInBlocks < X_MAX)
		{
			this.transform.position = new Vector3(mousePosInBlocks, 0.5f, 0f);
		}
	}
}
