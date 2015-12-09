using UnityEngine;
using System.Collections;

public class DuckDestroy : MonoBehaviour {


	Animator anim;

	bool isInvincible;

	// Use this for initialization
	void Start () {
		//use getcomponent to get the animator and assign to anim
		anim = GetComponent <Animator>();
	}
	
	// Update is called once per frame
	//void Update () {
	


	//}

	void OnTriggerEnter(Collider hit)
	{
		if (hit.tag == "Killzone")
		{
			Destroy (gameObject);
		}

		if (hit.tag == "Flyzone")
		{
			GameManager.OnDuckFlyAway();
			Destroy (gameObject);
		}
	}

	public void KillDuck()
	{
		if (isInvincible == false) 
		{
			anim.Play ("DuckDeath");
			GameManager.OnDuckShot();
		}
	}

	public void MakeInvincible()
	{
		isInvincible = true; 
	}
}
