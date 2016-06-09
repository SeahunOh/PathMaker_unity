using UnityEngine;
using System.Collections;

public class bombFire : MonoBehaviour {


	public float Speed = 100;
	public int damage = 20;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, 0.5f);
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(0.1f, 0.0f, 0.0f);
	}

	void OnTriggerEnter(Collider others)
	{
		Debug.Log (others.tag);

		if (others.CompareTag("BLOCK"))
		{
			Destroy(others.gameObject);
			Destroy(gameObject);
		}
	}
}
