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
	Vector3 axis;
	private int type;
	public bool isDestroy;
	public Block(float x, float y, float z, int inputType){
		type = inputType;
		isDestroy = (type & (int)BlockOption.BlockNotDestroy) == 1;
		axis = new Vector3(x,y,z);
		cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.transform.position = axis;
		cube.transform.localScale = new Vector3 (1, 1, 1);
	}
	/*void Start(){
		
	}
	void Update(){
		//cube.transform.Translate (m);

	}*/
}
