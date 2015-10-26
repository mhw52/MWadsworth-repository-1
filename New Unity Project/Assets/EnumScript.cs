using UnityEngine;
using System.Collections;

public class EnumScript : MonoBehaviour {



	enum Direction {North, East, South, West};


	// Use this for initialization
	void Start () {
	
		Direction myDirection;

		myDirection = Direction.North;


		
	}

	Direction ReverseDirection (Direction dir)
	{
		if (dir == Direction.North)
			dir = Direction.South;
		else if (dir == Direction.South)
			dir = Direction.North;
		else if (dir == Direction.East)
			dir = Direction.West;
		else if (dir == Direction.West)
			dir = Direction.East;

		

			return dir;

	}




}
