using System;

namespace ClownPuzzle
{
	public class You
	{	
		public static void Main (string[] args)
		{
			Volkswagen vw = new Volkswagen ();
			for (int i = 0; i < 10; i++)
			{
				vw.Add (new Clown ());
			}
			vw.Done ();
		}
	}
}

