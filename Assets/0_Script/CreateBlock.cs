using UnityEngine;
using System.Collections;

public class CreateBlock : MonoBehaviour {
	public GameObject user;
	public GameObject bomb1;
	public GameObject bombItem;
	public GameObject destination;
	public GameObject notDestroyBlock;
	public GameObject GrassBlock;
	public GameObject DestroyBlock;
	Block[,] bl;
	int stage;
	/*
	 *	0 : empty block 
	 *  1 : destroy block
	 *  2 : non destroy block
	 * 	3 : bomb item
	 *  8 : destination
	 *  9 : Character
	*/
	int[,] stage1_map1 = new int[10,10]{
		{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
		{ 1, 0, 2, 2, 2, 2, 2, 2, 2, 1 },
		{ 0, 2, 2, 3, 2, 3, 2, 0, 1, 0 },
		{ 0, 2, 0, 0, 2, 9, 2, 0, 2, 0 },
		{ 0, 2, 0, 2, 2, 0, 2, 0, 2, 0 },
		{ 0, 2, 0, 1, 0, 0, 2, 0, 2, 0 },
		{ 0, 2, 2, 2, 1, 2, 2, 0, 2, 0 },
		{ 0, 0, 8, 2, 0, 2, 3, 0, 2, 0 },
		{ 2, 2, 2, 2, 0, 2, 2, 2, 2, 0 },
		{ 3, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
	};

	int[,] stage2_map1 = new int[10,10]{
		{2,0,0,1,0,2,3,2,3,2},
		{2,3,2,0,0,2,1,2,0,2},
		{2,2,3,2,9,2,1,2,0,2},
		{2,2,0,2,0,2,0,0,1,2},
		{2,2,0,0,0,0,0,2,3,2},
		{2,2,2,2,1,2,1,2,2,2},
		{2,2,2,0,0,2,1,0,0,2},
		{2,3,2,1,0,0,2,2,1,2},
		{2,0,1,0,2,1,0,0,1,2},
		{2,2,2,2,2,2,2,2,8,2}
	};
		
	// Use this for initialization
	void Start () {
		stage = 1;
		bl = new Block[100, 2];
		int cnt = 0;
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 10; j++) {
				float x = (float)i;
				float z = (float)j;
				bl[cnt,0] = new Block (x, 0, z, 0, GrassBlock);
			}
		}
		cnt = 0;
		if(stage==1){
			for (int i = 0; i < 10; i++) {
				for (int j = 0; j < 10; j++) {
					if (stage1_map1 [i, j] == 4) {
						GameObject up = GameObject.CreatePrimitive (PrimitiveType.Plane);
						up.transform.localScale = new Vector3 (0.1f, 0.1f, Mathf.Sqrt (2) / 10.0f);
						up.transform.Rotate (45.0f, 90.0f, 0.0f);
						up.transform.position = new Vector3 (i, 1, j);
					} else if (stage1_map1 [i, j] == 3) {
						float x = (float)i;
						float z = (float)j;
						Instantiate (bombItem, new Vector3 (i, 1, j), transform.rotation);
						//bomb1.transform.parent = user;
					} else if (stage1_map1 [i, j] == 8) {
						GameObject dest = (GameObject)Instantiate (destination, new Vector3 (i, 0.55f, j), transform.rotation);
						dest.GetComponent<Renderer> ().material.color = Color.cyan;
						dest.tag = "DESTINATION";
					} else if (stage1_map1 [i, j] == 2) {
						float x = (float)i;
						float z = (float)j;
						bl [cnt, 1] = new Block (x, 1, z, stage1_map1 [i, j], notDestroyBlock);
					} else if (stage1_map1 [i, j] == 1) {
						float x = (float)i;
						float z = (float)j;
						bl [cnt, 1] = new Block (x, 1, z, stage1_map1 [i, j], DestroyBlock);
					} else if (stage1_map1 [i, j] == 9) {
						Instantiate (user, new Vector3(i,1,j), transform.rotation);
					}
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
