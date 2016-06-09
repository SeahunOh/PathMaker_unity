using UnityEngine;
using System.Collections;

public class bomb : MonoBehaviour {

	int[] dx = new int[] {1, 0, -1, 0};
	int[] dz = new int[] {0, -1, 0, 1};
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
			Destroy(gameObject, 0.5f);
			fire ();
		}
	}

	void fire(){
		for (int i = 0; i < 4; i++) {
			Vector3 bombfirePosition = transform.position;
			bombfirePosition.x += (float)dx [i] * 0.5f;
			bombfirePosition.z += (float)dz [i] * 0.5f;
			Instantiate (bombfire, bombfirePosition, Quaternion.Euler (0, 90 * i, 0));
		}
	}
		
}
