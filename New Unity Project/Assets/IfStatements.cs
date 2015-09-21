using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
	float coffeeTemperature = 85.0f;
	float hotLimitTemperature = 70.0f;
	float coldLimitTemperature = 40.0f;
	
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		
		coffeeTemperature -= Time.deltaTime * 5f;
	}


	void TemperatureTest (){
		if (coffeeTemperature > hotLimitTemperature) {
			print ("The Coffee is too Hot.");
		} else if (coffeeTemperature < coldLimitTemperature) {
			print ("The Coffee is too Cold.");
		} else {
			print ("The Coffee is just right.");
		}
	}

}

