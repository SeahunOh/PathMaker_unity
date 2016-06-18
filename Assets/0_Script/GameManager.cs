using UnityEngine;
using System.Collections;

public class GameManager
{
	private static GameManager instance;

	public static GameManager getInstance
	{
		get
		{
			if (instance == null)
			{
				instance = new GameManager();
				instance.stage = 1;
			}

			return instance;
		}
	}

	public int stage { set; get; }
}
