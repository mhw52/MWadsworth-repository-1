using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

	//How to declare an array
	int[] myArray = new int[5];

	//How to declare and initialize an array on the same line
	int[] SingleLineArray = {12,12,12,12,12};

	//How to access an array in the inspector
	public GameObject[] Players;


	// Use this for initialization
	void Start () {

		//How to access elements in the array
		myArray [0] = 12;
		myArray [1] = 12;
		myArray [2] = 12;
		myArray [3] = 12;
		myArray [4] = 12;

		SingleLineArray [2] = 24;

		//Tags
		Players = GameObject.FindGameObjectsWithTag("Player");

		//Using arrays in for loops
		for(int i=0; Players.Length > i ;i++)
		{
			int num = i+1;
			Debug.Log ("Player number "+num+" name is "+Players[i]);

		}


	}
	

}
