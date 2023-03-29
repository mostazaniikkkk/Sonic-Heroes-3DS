using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour {
	public bool loop;

	// Update is called once per frame
	void Update () {
		if (UnityEngine.N3DS.GamePad.GetButtonHold(N3dsButton.Start) || Input.GetKey(KeyCode.Space)){
			SceneManager.LoadScene("Stages/DebugStage");
		} else if(loop == true){
			loop = false;
			SceneManager.LoadScene("TitleScreen/TitleScreen");
		}
	}
}
