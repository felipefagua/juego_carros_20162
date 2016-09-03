using UnityEngine;
using System.Collections;

public class EnemyCarController : MonoBehaviour {
	public float  Speed;
	public Vector3 Direction;

	public float LifeTime = 0;
	// Use this for initialization
	void Start () {
		Invoke ( "Sleep",LifeTime);  
	}


	public void Sleep(){
		gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		move ();
	}
	public void move(){
		Vector3 step = Direction.normalized * Speed * Time.deltaTime;
		transform.Translate (step);
	}




}
