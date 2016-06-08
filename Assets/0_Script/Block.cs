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

	private int type;
	public bool isDestroy;
	public GameObject thePrefab;
	private Vector3 m_vPos;
	private Vector3 m_vAngle;
	Block(float x, float y, float z, int inputType){
		type = inputType;
		isDestroy = (type & (int)BlockOption.BlockNotDestroy) == 1;

	}
	void Start(){
		GameObject Instance = (GameObject) Instantiate(thePrefab, m_vPos, m_vAngle );
	}
	void Update(){
		
	}
}
