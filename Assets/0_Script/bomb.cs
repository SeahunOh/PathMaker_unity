using UnityEngine;
using System.Collections;

public class bomb : MonoBehaviour {

	public GameObject bombfire;

	public int range = 1;
	public bool isFire = false;
	public int startTime;
	//public int pTime;
	//private float prevTime;

	// Use this for initialization
	void Start () {
	//	prevTime = (int)Time.time;

	}
	
	// Update is called once per frame
	void Update () {

		if( Input.GetKeyDown( KeyCode.Space ) && !isFire){
			Debug.Log( "Space key was pressed." );
			startTime = (int)Time.time;
			isFire = true;
			fire ();
		}
			
		if (isFire) {
			Debug.Log ((int)Time.time - startTime);
			if ((int)Time.time - startTime> 3) {
				Destroy (gameObject);
			}
		}
	}

	void fire(){
		for (int i = 0; i < 4; i++) {
			Instantiate (bombfire, transform.position, Quaternion.Euler (0, 90 * i, 0));
		}
	}
		
}
