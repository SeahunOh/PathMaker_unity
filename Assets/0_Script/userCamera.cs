using UnityEngine;
using System.Collections;

public class userCamera : MonoBehaviour {
	public GameObject userCam;
	public GameObject userCharacter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		userCam.transform.LookAt (userCharacter.transform);
	}
}
