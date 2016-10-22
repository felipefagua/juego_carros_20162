using UnityEngine;
using System.Collections;

public class Invoker : MonoBehaviour {

	public KeyCode _KeyAccelerate;
	public KeyCode _keyRight;
	public KeyCode _keyLeft;
	public KeyCode _keyBack;

	PlayerCarController Play;

	Comand UpComand;
	Comand DownComand;
	Comand LeftComand;
	Comand rightComand;
	Comand Stopcomand;

	//public static ArrayList ListComands = new ArrayList(); //lista para guardar comandos


	void Start (){
		UpComand = new UpComand();
		DownComand = new DownComand ();
		LeftComand = new LeftComand ();
		rightComand = new RightComand ();
		Stopcomand = new StopComand ();

		Play = this.gameObject.GetComponent<PlayerCarController> ();
	}

	void Update(){
		Keys ();

	}

	public void Keys(){

		if (Input.GetKey (_KeyAccelerate)) {
			UpComand.execute (Play);
			//ListComands.Add (UpComand);//Guardo el comando en la lista
		}
		else if (Input.GetKey (_keyBack)) {
			DownComand.execute (Play);
			//ListComands.Add (DownComand);//Guardo el comando en la lista
		}else {
			Stopcomand.execute (Play);
			//ListComands.Add (Stopcomand);//Guardo el comando en la lista
			}
			
		if (Input.GetKey(_keyRight)){
			rightComand.execute(Play);
			//ListComands.Add (rightComand);//Guardo el comando en la lista
		}
		if (Input.GetKey(_keyLeft)){
			LeftComand.execute(Play);
			//ListComands.Add (LeftComand);//Guardo el comando en la lista
		}
	}
}
