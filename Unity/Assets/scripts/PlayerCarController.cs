using UnityEngine;
using System.Collections;

public class PlayerCarController : MonoBehaviour {
	public Vector3 _direction;
	public float _speed;
	public float _maxSpeed;

	public KeyCode _KeyAccelerate;
	public KeyCode _keyRight;
	public KeyCode _keyLeft;
	public KeyCode _keyBack;

	public float _acceleration;
	public float rotation;
	public float _damp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		acelerate ();
		rotate ();
		moveCar ();
	}


	public void acelerate(){
		if (Input.GetKey (_KeyAccelerate)) {
			_speed += Time.deltaTime * _acceleration;
			if (_speed > _maxSpeed) {
				_speed = _maxSpeed;			
			}
		}
		//retroceso  del carro//
		else if (Input.GetKey (_keyBack)) {
			_speed -= Time.deltaTime * _acceleration;
			if (_speed <= _maxSpeed * -1) {
				_speed = _maxSpeed * -1;			
			}
		}
		//desaceleracion del carro//
		else {
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
	}


	public void rotate(){
	
		//girar carro a la derecha//
		if (Input.GetKey(_keyRight)){
			rotateCar (rotation);
		}
		// girar carro a al izquierda//
		if (Input.GetKey(_keyLeft)){
			rotateCar (rotation * -1);
		}
	}

	public void rotateCar(float rotation) {
		if (_speed != 0) {
			if (_speed < 0) {
				rotation *= -1;
			}
			this.transform.Rotate (new Vector3 (0, (rotation) * Time.deltaTime, 0));	
		}
	}

	private void moveCar(){
		Vector3 step = _direction.normalized * _speed * Time.deltaTime;
		transform.Translate(step);
	}
}
