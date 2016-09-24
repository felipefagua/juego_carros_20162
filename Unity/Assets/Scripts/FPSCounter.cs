using UnityEngine;

using UnityEngine.UI;

using System.Collections;


public class FPSCounter : MonoBehaviour {


	public Text _fpsText;

	
// Use this for initialization
	
void Start () {
	
	}
	
	
// Update is called once per frame
	
void Update () {
		
float fps = (1000/Time.deltaTime)/1000;
		
_fpsText.text = "fps: " + fps;

	}

}
