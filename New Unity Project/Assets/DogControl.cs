using UnityEngine;
using System.Collections;

public class DogControl : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		GameManager.OnDuckDeath += PlayDuck;
		GameManager.OnDuckFlyAway += PlayLaugh;
	}
	
	// Update is called once per frame
	//void Update () {
	
	//}

	public void SpawnDuck()
	{
		GameManager.OnSpawnDuck ();
	}
	public void PlayLaugh()
	{
		anim.Play ("DogLaugh");
	}

	public void PlayDuck()
	{
		anim.Play ("DogDuck");
	}
}
