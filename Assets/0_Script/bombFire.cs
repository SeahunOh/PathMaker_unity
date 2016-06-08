using UnityEngine;
using System.Collections;

public class bombFire : MonoBehaviour {


	public float Speed = 100;
	public int damage = 20;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, 10.0f);
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(0.1f, 0.0f, 0.0f);
	}

	void OnTriggerEnter(Collider others)
	{
		if (others.CompareTag("WALL"))
		{
			Destroy(others);
			Destroy(gameObject);
		}
	}
}
