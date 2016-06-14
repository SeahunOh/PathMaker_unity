using UnityEngine;
using System.Collections;

public class moveScene : MonoBehaviour {
	public string sceneName;

	void OnGUI(){
		if(Input.GetKey(KeyCode.Return)){
			Application.LoadLevel (sceneName);
		}	
	}
}
