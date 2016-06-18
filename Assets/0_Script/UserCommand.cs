using UnityEngine;
using System.Collections;

public class UserCommand : MonoBehaviour {

	public int bombCnt = 0;
	public GameObject bomb;
	bool fieldInBomb = false;
	GameObject makeBomb;
	private GameManager manager;
	public GameObject stageClear;
	// Use this for initialization
	void Start () {
		manager = GameManager.getInstance;
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
		if (transform.position.y < -15.0f) {
			Application.LoadLevel ("GameOver");
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
			Debug.Log (manager.stage);
			if (manager.stage != 3) {
				Debug.Log ("nextStage");
				manager.stage++;
				Debug.Log (manager.stage);
				string nextScene = "Main" + manager.stage.ToString ();
				Application.LoadLevel (nextScene);
			} else {
				Debug.Log ("USER WIN!");
				Application.LoadLevel ("GameClear");
			}

		}
	}
}
