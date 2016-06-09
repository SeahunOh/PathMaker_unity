using UnityEngine;
using System.Collections;

public class CreateBlock : MonoBehaviour {
	public GameObject user;
	public GameObject bombItem;
	Block[,] bl;
	int[,] stage1_map1 = new int[10,10]{
		{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
		{ 0, 1, 1, 1, 0, 0, 1, 1, 1, 0 },
		{ 0, 1, 0, 0, 0, 0, 0, 0, 1, 0 },
		{ 0, 1, 0, 1, 1, 1, 1, 0, 1, 0 },
		{ 0, 1, 0, 1, 0, 0, 1, 0, 1, 0 },
		{ 0, 1, 0, 1, 0, 0, 1, 0, 1, 0 },
		{ 0, 1, 0, 0, 0, 0, 0, 0, 1, 0 },
		{ 0, 1, 0, 0, 0, 0, 0, 0, 1, 0 },
		{ 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
		{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
	};
	// Use this for initialization
	void Start () {
		bl = new Block[100, 2];
		int cnt = 0;
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 10; j++) {
				float x = (float)i;
				float z = (float)j;
				bl[cnt,0] = new Block (x, 0, z, 0);
				if((x+z)%2!=0)
					bl[cnt++,0].getCube().GetComponent<Renderer> ().material.color = Color.black;
				else
					bl[cnt++,0].getCube().GetComponent<Renderer> ().material.color = Color.white;
			}
		}
		cnt = 0;
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 10; j++) {
				if (stage1_map1 [i,j] == 1) {
					float x = (float)i;
					float z = (float)j;
					bl[cnt,1] = new Block (x, 1, z, 0);
					bl[cnt++,1].getCube().GetComponent<Renderer> ().material.color = Color.white;
				}
			}
		}
		Vector3 userPosition = transform.position;
		userPosition.x += 5;
		userPosition.y += 1;
		userPosition.z += 4;
		Instantiate (user, userPosition, transform.rotation);
		Vector3 bombItemPosition = transform.position;
		bombItemPosition.x += 6;
		bombItemPosition.y += 1;
		bombItemPosition.z += 4;
		Instantiate (bombItem, bombItemPosition, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
