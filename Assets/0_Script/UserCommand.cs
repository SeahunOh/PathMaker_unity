using UnityEngine;
using System.Collections;

public class UserCommand : MonoBehaviour {

	public GameObject bomb;
	bool fieldInBomb = false;
	GameObject makeBomb;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (fieldInBomb) {
			if (makeBomb == null) {
				Debug.Log ("Bomb is not exist.");
				fieldInBomb = false;
			}
		}
		else if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log ("Space key was pressed.");
			Debug.Log ("Create Bomb.");
			fieldInBomb = true;
			Vector3 bombPosition = transform.position;
			bombPosition.y += 0.5f;
			makeBomb = (GameObject)Instantiate (bomb, bombPosition, transform.rotation);
		}
	}
}
