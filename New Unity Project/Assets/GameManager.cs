using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public delegate void Duckdel();
	public static Duckdel OnSpawnDuck;
	public static Duckdel OnDuckShot;
	public static Duckdel OnDuckDeath;
	public static Duckdel OnDuckFlyAway;
	public static Duckdel OnDuckMiss;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
