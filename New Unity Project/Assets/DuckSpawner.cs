using UnityEngine;
using System.Collections;

public class DuckSpawner : MonoBehaviour {


	public GameObject Duck;
	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {
	
	//}

	public void SpawnDuck()
	{
		Instantiate (Duck, transform.position, Quaternion.identity);
	}
}
