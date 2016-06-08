using UnityEngine;
using System.Collections;

public class player_ctrl: MonoBehaviour {

	public GameObject bullet;

	public int life = 10;

	public float cubeSpeed;

	public int startTime;
	public int playTime;

	public float bulletDelay = 1.0f;
	private float prevTime;

	private bool canBomb = false;

	// Use this for initialization
	void Start () {
		prevTime = Time.time;
		startTime = (int)Time.time;
	}
	
	// Update is called once per frame
	void Update()
	{
		playTime = (int)(Time.time - startTime);

		if (Input.GetKey(KeyCode.LeftArrow) == true)
		{
			transform.Translate(Vector3.left * 10.0f * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.RightArrow) == true)
		{
			transform.Translate(Vector3.right * 10.0f * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.UpArrow) == true)
		{
			transform.Translate(Vector3.forward * 10.0f * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.DownArrow) == true)
		{
			transform.Translate(Vector3.back * 10.0f * Time.deltaTime);
		}

		// 
		if (Input.GetKey(KeyCode.Space) == true)
		{
			if (canBomb) {
				canBomb = false;
			} else {
				canBomb = true;
			}
		}

		if (Time.time - prevTime > bulletDelay)
		{
			if (Input.GetKey(KeyCode.X) == true)
			{
				Instantiate(bullet, transform.position, transform.rotation);
			}
			prevTime = Time.time;
		}

		if(life <= 0)
		{
			Application.LoadLevel(2);
		}
	}
}
