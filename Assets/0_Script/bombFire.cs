using UnityEngine;
using System.Collections;

public class bombFire : MonoBehaviour {
	public float Speed = 100;
	public int damage = 20;
	public GameObject fireEffect;
	private float prevTime;

	// Use this for initialization
	void Start () {
		prevTime = Time.time;
		Destroy(gameObject, 0.5f);
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(0.1f, 0.0f, 0.0f);
		if (Time.time - prevTime >= 0.1f) {
			
			prevTime = Time.time;
		}
	}

	void OnTriggerEnter(Collider others)
	{
		Debug.Log (others.tag);

		if (others.CompareTag ("BLOCK")) {
			Instantiate (fireEffect, transform.position, transform.rotation);
			Destroy (others.gameObject);
			Destroy (gameObject);
		}
		else if(others.CompareTag("USER")){
			Destroy(others.gameObject);
			Destroy (gameObject);
			Application.LoadLevel ("GameOVer");
		}
	}
}
