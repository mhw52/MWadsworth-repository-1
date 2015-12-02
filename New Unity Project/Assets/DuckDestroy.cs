using UnityEngine;
using System.Collections;

public class DuckDestroy : MonoBehaviour {

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {
	


	//}

	void OnTriggerEnter(Collider hit)
	{
		if (hit.tag == "Killzone")
		{
			Destroy (gameObject);
		}
	}
}
