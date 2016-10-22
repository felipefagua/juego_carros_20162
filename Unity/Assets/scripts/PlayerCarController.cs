using UnityEngine;
using System.Collections;

public class PlayerCarController : MonoBehaviour, Actor {
	public Vector3 _direction;
	public float _speed;
	public float _maxSpeed;

	public float _acceleration;
	public float rotation;
	public float _damp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		moveCar ();
	}

	public void rotateCar(float rotation) {
		if (_speed != 0) {
			if (_speed < 0) {
				rotation *= -1;
			}
			this.transform.Rotate (new Vector3 (0, (rotation) * Time.deltaTime, 0));	
		}
	}



		public void Up(){
			_speed += Time.deltaTime * _acceleration;
			if (_speed > _maxSpeed) {
			_speed = _maxSpeed;			
			}
		}

		public void Down(){
			_speed -= Time.deltaTime * _acceleration;
			if (_speed <= _maxSpeed * -1) {
			_speed = _maxSpeed * -1;			
		}
		}

	public void stop(){
		float speedIncrement = Time.deltaTime * _damp;
		if (_speed > 0) {
			_speed -= speedIncrement;
		} else {
			_speed += speedIncrement;
		}

		if (Mathf.Abs (_speed) < 0.9f) {
			_speed = 0;		

		}
	}
	public void left(){
		rotateCar (rotation *-1);
	}
	public void right(){
		rotateCar (rotation);
	}


	private void moveCar(){
		Vector3 step = _direction.normalized * _speed * Time.deltaTime;
		transform.Translate(step);
	}
}
