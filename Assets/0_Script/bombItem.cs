using UnityEngine;
using System.Collections;

public class bombItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider others)
	{
		Debug.Log (others.tag);

		if (others.CompareTag("USER"))
		{
			
			Destroy(gameObject);
		}
	}
}
