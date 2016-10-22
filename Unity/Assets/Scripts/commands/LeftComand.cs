using System;

public class LeftComand : Comand {
	public override void execute (Actor jugador)
	{
		((PlayerCarController)jugador).left();
	}
}