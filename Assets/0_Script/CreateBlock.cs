using UnityEngine;
using System.Collections;

public class CreateBlock : MonoBehaviour {
	public GameObject user;
	public GameObject bomb1;
	public GameObject bombItem;
	public GameObject destination;

	Block[,] bl;
	int[,] stage1_map1 = new int[10,10]{
		{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
		{ 0, 1, 1, 1, 0, 0, 1, 1, 1, 0 },
		{ 0, 1, 0, 0, 0, 0, 0, 3, 1, 0 },
		{ 0, 1, 0, 1, 1, 1, 1, 0, 1, 0 },
		{ 0, 1, 0, 1, 2, 4, 1, 0, 1, 0 },
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
				if (stage1_map1 [i, j] == 4) {
					GameObject up= GameObject.CreatePrimitive(PrimitiveType.Plane);
					up.transform.localScale= new Vector3(0.1f, 0.1f, Mathf.Sqrt(2)/10.0f);
					up.transform.Rotate(45.0f, 90.0f, 0.0f);
					up.transform.position = new Vector3 (i, 1, j);
				}
				else if (stage1_map1 [i, j] == 3) {
					float x = (float)i;
					float z = (float)j;
					Instantiate (bombItem, new Vector3 (i, 0, j), transform.rotation);
					//bomb1.transform.parent = user;
				} else if (stage1_map1 [i, j] == 8) {
					GameObject dest = (GameObject)Instantiate (destination, new Vector3 (i, 0.55f, j), transform.rotation);
					dest.GetComponent<Renderer> ().material.color = Color.cyan;
					dest.tag = "DESTINATION";
				} else if (stage1_map1 [i, j] != 0){
					float x = (float)i;
					float z = (float)j;
					bl[cnt,1] = new Block (x, 1, z, stage1_map1[i,j]);
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
