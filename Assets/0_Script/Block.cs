using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
	public enum BlockOption{
		BlockNormal = 0x01,
		BlockNotDestroy = 0x02,
		GroundNormal = 0x10,
		GroundTrap = 0x20,
		GroundGenerator = 0x40,
	}
	GameObject cube;
	Vector3 m;
	private int type;
	public bool isDestroy;
	Block(float x, float y, float z, int inputType){
		type = inputType;
		isDestroy = (type & (int)BlockOption.BlockNotDestroy) == 1;

	}
	void Start(){
		cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
	
		m = new Vector3(0.0f,0.0f,1.0f);
	}
	void Update(){
		//cube.transform.Translate (m);

	}
}
