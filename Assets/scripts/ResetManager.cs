using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetManager : MonoBehaviour {
	//public bool canRestart = false;

	void Update () {
		if (Input.GetKeyDown(KeyCode.R) && Pathmaker.canRestart == true) {
			print ("space key was pressed");
			Pathmaker.totalTileCount = 0;
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}
}
