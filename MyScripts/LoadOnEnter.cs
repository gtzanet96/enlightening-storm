using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnEnter : StateMachineBehaviour {

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		if (Application.loadedLevelName.Equals("MainMenu")){
			SceneManager.LoadScene (1);
		}
		if (Application.loadedLevelName.Equals("VictoryScreen")){
			SceneManager.LoadScene (1);
		}
	}
}
					