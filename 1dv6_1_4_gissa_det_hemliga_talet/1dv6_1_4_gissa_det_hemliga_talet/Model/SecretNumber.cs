using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1dv6_1_4_gissa_det_hemliga_talet.Model
{
	public enum Outcome { Indefinite, Low, High, Correct, NoMoreGuesses, PreviousGuess };

	public class SecretNumber
	{
		//Fält
		private int _number;
		private List<int> _previousGuesses;
		public const int MaxNumberOfGuesses = 7;

		public bool CanMakeGuess
		{ }

		public int Count
		{ }
	}
}