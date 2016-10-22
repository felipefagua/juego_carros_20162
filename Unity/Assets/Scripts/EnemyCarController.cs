using UnityEngine;

using System.Collections;


public class EnemyCarController : MonoBehaviour {
		
	public float _lifeTime;
	PlayerCarController Play;
	Comand UpComand;


	void Start (){
		UpComand = new UpComand();
		Play = this.gameObject.GetComponent<PlayerCarController> ();
	}

	
	// Use this for initialization
	
	void OnEnable () {
		
		Invoke ("GotoSleep", _lifeTime);
	
	}

	
	public void GotoSleep(){
		
		gameObject.SetActive (false);	
	
	}

	
	// Update is called once per frame
	
 	void Update () {
		TruckCar();

	}

	public void TruckCar(){
		UpComand.execute(Play);
	}

  	


	public void OnDisable(){

		CancelInvoke ();
	}

}
