using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private static GameManager instance;

	public static GameManager getInstance
	{
		get
		{
			if(instance==null)
			{
				GameObject obj = new GameObject("obj");
				instance = obj.AddComponent(typeof(GameManager)) as GameManager;
				instance.stage = 1;
			}
			return instance;
		}
	}

	public int stage { set; get; }
}
