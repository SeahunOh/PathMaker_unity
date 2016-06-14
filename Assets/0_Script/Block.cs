using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
	public enum BlockOption{
		BlockNormal = 0x01,
		BlockNotDestroy = 0x02,
		BlockItem = 0x04,
		GroundNormal = 0x10,
		GroundTrap = 0x20,
		GroundGenerator = 0x40,
	}
	GameObject cube;
	Vector3 axis;
	private BlockOption type;
	public bool isDestroy;

	public Block(float x, float y, float z, int inputType){
		
		type = (BlockOption)inputType;
		axis = new Vector3(x,y,z);
		cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.transform.position = axis;
		cube.transform.localScale = new Vector3 (1,1,1);
		if (type == BlockOption.BlockNormal) {
			cube.tag = "BLOCK";
		} else if (type == BlockOption.BlockNotDestroy) {
			cube.tag = "NOT_DEST_BLOCK";
		}
	}
	public GameObject getCube(){
		return cube;
	}
}
