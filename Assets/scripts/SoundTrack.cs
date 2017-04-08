using UnityEngine;
using System.Collections;

public class SoundTrack : MonoBehaviour {

	static SoundTrack mpInstance = null;
	
	void Awake(){
		// init the game music
		if (mpInstance != null)
			// we already have a soundtrack; don't need another
			Destroy(gameObject);
		else
		{
			// we don't have a soundtrack yet; get set up!
			mpInstance = this;
			// keep the music going between scenes
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
