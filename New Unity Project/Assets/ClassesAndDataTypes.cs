using UnityEngine;
using System.Collections;

public class ClassesAndDataTypes : MonoBehaviour {

	public class Inventory
	{
		public int bullets;
		public int grenedes;
		public int rockets;


		public Inventory()
		{
			bullets = 5;
			grenedes = 5;
			rockets = 5;

		}

		public Inventory(int bul, int gre, int roc)
		{
			bullets = bul;
			grenedes = gre;
			rockets = roc;

		}


	}

	void Start()
	{
		Inventory myInventory = new Inventory (3,4,5);
		Inventory inv2 = myInventory;
		inv2.bullets = 1000;

		//Value types
		int num1 = 5;
		int num2 = num1;
		num2 = 100;

		GameObject obj = gameObject;

		Transform trans1 = transform;
		Transform trans2 = trans1;


	}



}
