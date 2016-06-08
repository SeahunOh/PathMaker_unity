using UnityEngine;
using System.Collections;

public class CreateBlock : MonoBehaviour {
	Block[] bl;
	// Use this for initialization
	void Start () {
		bl = new Block[100];
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 10; j++) {
				float x = (float)i;
				float z = (float)j;
				bl [i] = new Block (x, 0, z, 0);
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		

	}
}
