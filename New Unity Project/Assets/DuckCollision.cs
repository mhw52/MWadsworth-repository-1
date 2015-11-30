using UnityEngine;
using System.Collections;

public class DuckCollision : MonoBehaviour {

	public enum Changer{Horizontal, Vertical};
	public Changer direction;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnCollisionEnter(Collision hit)
	{
		if (hit.transform.tag == "Duck")
		{
			Duckhuntscript movement = hit.transform.GetComponent < Duckhuntscript>();

			if(direction == Changer.Horizontal)
			{
				movement.DirectionChanger(new Vector3(-1f, 1f, 0));
			}
			if(direction == Changer.Vertical)
			{
				movement.DirectionChanger(new Vector3(1f, -1f, 0));
			}
		
		}
	}
}
