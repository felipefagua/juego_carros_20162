using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public KeyCode tecla;
	public SpawnPool SP;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown(tecla)){
		GameObject truck = SP.SpownObject (); // asi se genera el objeto
			Vector3 eulerAngles = new Vector3 (0,Random.value * 360 ,0); 
			truck.transform.Rotate (eulerAngles);
			truck.transform.position = new Vector3 ();
		}
	}
}
