using UnityEngine;
using System.Collections;

public class UserCommand : MonoBehaviour {

	public int bombCnt = 0;
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
			if (bombCnt > 0) {
				Debug.Log ("Space key was pressed.");
				fieldInBomb = true;
				Vector3 bombPosition = transform.position;
				bombPosition.y += 0.5f;
				makeBomb = (GameObject)Instantiate (bomb, bombPosition, transform.rotation);
				bombCnt--;
				Debug.Log ("Create Bomb : " + bombCnt);
			} else {
				Debug.Log ("have not BOMB");
			}
		}
	}

	void OnTriggerEnter(Collider others)
	{
		Debug.Log (others.tag);

		if (others.CompareTag ("BOMB_ITEM")) {
			bombCnt++;
			Debug.Log ("GET BOMB : " + bombCnt);
			Destroy (others.gameObject);
		} else if (others.CompareTag ("DESTINATION")) {
			Debug.Log ("USER WIN!");
			Application.LoadLevel ("GameOVer");
		}
	}
}
