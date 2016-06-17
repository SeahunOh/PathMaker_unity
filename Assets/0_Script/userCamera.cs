using UnityEngine;
using System.Collections;

public class userCamera : MonoBehaviour {
	public GameObject userCam;
	public GameObject topView;
	public Camera cam_user;
	public Camera cam_top;
	public GameObject userCharacter;
	private bool flag;
	// Use this for initialization
	void Start () {
		flag = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			if (!flag) {//45 30 45
				flag = true;
				cam_user.enabled = false;
				cam_top.enabled = true;
			} else {
				flag = false;
				cam_user.enabled = true;
				cam_top.enabled = false;
			}
		}
		if (flag) {
			userCam.transform.LookAt (userCharacter.transform);
		} else {
			userCam.transform.LookAt (userCharacter.transform);
		}


	}
}
