using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

		// Ger ett värde som indikerar om en gissning kan göras eller inte
		public bool CanMakeGuess 
		{
			get
			{
				return !(_previousGuesses.Count == MaxNumberOfGuesses
					|| Outcome.PreviousGuess == Outcome.NoMoreGuesses);
			}
		}

		// Ger antalet gjorda gissningar 
		public int Count 
		{ 
			get { return _previousGuesses.Count; }
		}
		

		// Sätter det hemliga talet
		public int? Number
		{
			get 
			{
				if (CanMakeGuess)
				{
					return null;
				}
				return _number; 
			}
		}

		// Ger resultat av den senast utförda gissningen
		public Outcome Outcome { get; private set; }

		// Ger referens till en samling innehållande gjorda gissningar
		public ReadOnlyCollection<int> PreviousGuesses
		{
			get { return _previousGuesses.AsReadOnly(); }
		}

		// Initierar klassens medlemmar
		public void Initialize()
		{
			_previousGuesses.Clear();
			Outcome = Outcome.Indefinite;
			Random randomNumber = new Random();
			_number = randomNumber.Next(1, 101);
		}

		// Returnerar värde på det gissade talet
		public Outcome MakeGuess(int guess)
		{
			if (guess < 1 || guess > 100) 
			{
				throw new ArgumentOutOfRangeException();
			}

			if (Count > MaxNumberOfGuesses)
			{
				throw new ApplicationException();
			}

			if (Count == MaxNumberOfGuesses)
			{
				return Outcome.NoMoreGuesses;
			}

			if (PreviousGuesses.Contains(guess))
			{
				return Outcome.PreviousGuess;
			}
			_previousGuesses.Add(guess);

			if (guess > _number)
			{
				return Outcome.High;
			}
			else if (guess < _number)
			{
				return Outcome.Low;
			}
			else
			{
				return Outcome.Correct;
			}
		}

		//Konstruktor
		public SecretNumber()
		{
			_previousGuesses = new List<int>(MaxNumberOfGuesses);
			Initialize();
		}
	}
}