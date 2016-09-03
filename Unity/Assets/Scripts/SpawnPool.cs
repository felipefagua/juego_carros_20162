using UnityEngine;
using System.Collections;

public class SpawnPool : MonoBehaviour {

	public GameObject prototipe;

	public int TamañoPool;

	public GameObject [] proto;


	public void  Onenable(){
		proto =  new GameObject[TamañoPool]; 
		for (int i = 0; i < TamañoPool; i++) {
			GameObject copy = Instantiate(prototipe);
			copy.SetActive (false);
			proto [i] = copy; 
		}
			
	}
	public GameObject SpownObject(){
		foreach ( GameObject poolObject in proto){
			if (!poolObject.activeSelf)
				return poolObject;
		}

		return null;
	}
}
