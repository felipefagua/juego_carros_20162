using System;

public class RightComand : Comand {
	public override void execute (Actor jugador)
	{
		((PlayerCarController)jugador).right();
	}
}