using UnityEngine;
using System.Collections;

public class variablescript : MonoBehaviour 
{
	int myInt = 5;

	void Start(){
		myInt = MultiplyByTwo (myInt);
		Debug.Log (myInt);
	
	}
	int MultiplyByTwo(int Number){

		int ret;
		ret = Number * 2;
		return ret;
	}
}
