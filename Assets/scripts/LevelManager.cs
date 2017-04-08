using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void QuitGame(){
		Debug.Log("inside QuitGame");
		Application.Quit();
	}

	public void LoadLevel(string name){
		Debug.Log("inside LoadLevel, name = " + name);
		Application.LoadLevel(name);
	}
}
