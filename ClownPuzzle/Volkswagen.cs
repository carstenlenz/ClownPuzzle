using System;
using System.Collections.Generic;

namespace ClownPuzzle
{
	public class Volkswagen
	{
		private const int CAPACITY = 5;
		private readonly HashSet<Clown> clowns = new HashSet<Clown>();
		
		public virtual void Add (Clown clown)
		{
			lock (this) // Only one thread at a time can access this
			{
				if (clowns.Count > CAPACITY)
				{
					throw new InvalidOperationException ("I'm full");
				} 
				else
				{
					clowns.Add (clown);
				}
			}
		}
		
		public virtual void Done ()
		{
			lock (this) // Only one thread at a time can access this
			{
				if (clowns.Count == 10)
				{
					Console.WriteLine ("I'm a Volkswagen with 10 clowns!");
				}
			}
		}
	}
}

