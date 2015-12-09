using UnityEngine;
using System.Collections;

public class Duckhuntscript : MonoBehaviour {

	public float speed;
	public Vector3 direction;


	private int bounce;
	public int bounceMax;

	// Use this for initialization
	void Start () {
		GameManager.OnDuckShot += StopMovement;
		GameManager.OnDuckMiss += FlyAway; 
		RandomDirection();
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = transform.position + (direction * speed);

	}

	public void RandomDirection()
	{
		direction = new Vector3(Random.Range(-1f,1f), Random.Range(.2f,1f), 0);
		Debug.Log(direction);
	}

	public void DirectionChanger(Vector3 _drt)
	{
		direction = new Vector3 (direction.x * _drt.x, direction.y * _drt.y); 

		bounce++;

		if (bounce >= bounceMax) 
		{
			direction = new Vector3(0,1,0);
			GameManager.OnDuckMiss();
		
		}
	}

	public void StopMovement()
	{
		direction = new Vector3 (0, 0, 0);
	}

	public void Startfall()
	{
		direction = new Vector3 (0, -1, 0);
	}

	public void FlyAway()
	{
		direction = new Vector3 (0, 1, 0);
	}
}
