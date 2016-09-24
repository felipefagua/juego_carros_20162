using UnityEngine;
using System.Collections;

public class SpwanPool : MonoBehaviour {

	public GameObject _prototype;

	public int _size;

	public GameObject[] _objects;
	public float Seconds=5;


	private void Start() {
		_objects = new GameObject[_size];
		for (int i = 0; i < _size; i++) {
			GameObject copy = Instantiate (_prototype);

			copy.SetActive(false);
			_objects[i] = copy;
		}

		InvokeRepeating ("GetObject",Seconds,Seconds);

	}

	public void GetObject (){
		
		GameObject car = SpawnObject(); 
		if (car != null) {
			Vector3 newPosition = new Vector3(0,0,0);
			car.transform.position = newPosition;
			car.SetActive (true);
		}
	
	}

	public GameObject SpawnObject() {
		foreach (GameObject poolObject in _objects) {
			if (!poolObject.activeSelf)
				return poolObject;
		}

		return null;
	}

}
