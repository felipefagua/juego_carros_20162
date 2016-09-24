using UnityEngine;

using System.Collections;


public class EnemyCarController : MonoBehaviour {

	
public Vector3 _direction;
	
public float _speed;
		
public float _lifeTime;

	
	// Use this for initialization
	
	void OnEnable () {
		
		Invoke ("GotoSleep", _lifeTime);
	
	}

	
	public void GotoSleep(){
		
		gameObject.SetActive (false);	
	
	}

	
	// Update is called once per frame
	
 	void Update () {
		
       moveCar();

	}



  	private void moveCar(){

		Vector3 step = _direction.normalized * _speed * Time.deltaTime;
		transform.Translate(step);

	}


	public void OnDisable(){

		CancelInvoke ();
	}

}
