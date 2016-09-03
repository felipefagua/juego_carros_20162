using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FPSCounter : MonoBehaviour {
	public float FramesSecond=0;
	public Text FpsText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		FramesSecond = (1000/Time.deltaTime)/1000;
		FpsText.text = "PFS: " + FramesSecond;
	}
}
