using System;

public class StopComand : Comand {
	public override void execute (Actor jugador)
	{
		((PlayerCarController)jugador).stop();
	}
}