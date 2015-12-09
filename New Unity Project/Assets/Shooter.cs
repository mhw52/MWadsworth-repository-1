using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {


	RaycastHit hit;

	private int bulletAmt;
	public int maxBullets;

	// Use this for initialization
	void Start () {
		GameManager.OnSpawnDuck += ResetBullets;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0))
		{
			bulletAmt --;

			if(bulletAmt <=0)
			{
				GameManager.OnDuckMiss();
			}
		
		
			Vector3 mousePos = Input.mousePosition;
			mousePos.z = Camera.main.transform.position.z;

			if(Physics.Raycast (Camera.main.ScreenToWorldPoint(mousePos), Camera.main.transform.forward, out hit, Mathf.Infinity))
			{
				if(hit.transform.tag == "Duck")
				{
					DuckDestroy Shot = hit.transform.GetComponent <DuckDestroy>();
					Shot.KillDuck();
				}
			}
		}
	}

	public void ResetBullets()
	{
		bulletAmt = maxBullets;
	}
}
