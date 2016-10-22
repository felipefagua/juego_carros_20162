using UnityEngine;
using System.Collections;

public class UpComand : Comand {
	public override void execute (Actor jugador)
	{
		((PlayerCarController)jugador).Up();
	}
}