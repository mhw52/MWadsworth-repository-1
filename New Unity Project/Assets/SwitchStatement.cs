using UnityEngine;
using System.Collections;

public class SwitchStatement : MonoBehaviour {

	public int age = 5;


	void Start()
	{
		Greet ();
	}

	void Greet()
	{
	
		switch (age) {

		case 5: 
			print("reeses pieces!");
			break;
		case 4: 
			print("m&m!");
			break;
		case 3: 
			print("suckers");
			break;
		case 2: 
			print("jelly beans!");
			break;
		case 1: 
			print("chocolate");
			break;

		default:
			print ("candy");
			break;



		}


	}
	

}
