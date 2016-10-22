using System;

public class DownComand : Comand {
	public override void execute (Actor jugador)	{
		((PlayerCarController)jugador).Down();
	}
}