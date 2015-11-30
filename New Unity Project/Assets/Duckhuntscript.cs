using UnityEngine;
using System.Collections;

public class Duckhuntscript : MonoBehaviour {

	public float speed;
	public Vector3 direction;

	// Use this for initialization
	void Start () {
	
		RandomDirection();
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = transform.position + (direction * speed);

	}

	public void RandomDirection()
	{
		direction = new Vector3(Random.Range(-1f,1f), Random.Range(.2f,2f), 0);
	}

	public void DirectionChanger(Vector3 _drt)
	{
		direction = new Vector3 (direction.x * _drt.x, direction.y * _drt.y); 
	}
}
