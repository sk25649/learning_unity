using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		startGame ();
	}

	void startGame () {
		max = 1000;
		min = 1;
		guess = 500;
		max = max + 1;
		print ("==========================");
		print ("welcome to number wizard");
		print ("Pick a number but don't tell me");
		print ("the highest number you can pick is " + max);
		print ("the lowest number you can pick is " + min);
		print ("Is the number highest or lower than " + guess );
		print ("up = higher, down = lower, return = equal");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			nextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			nextGuess();
		} else if(Input.GetKeyDown(KeyCode.Return)) {
			print("I won!");
			startGame();
		}
	}

	void nextGuess () {
		guess = (max + min)/2;
		print ("higher or lower than " + guess);
		print ("up = higher, down = lower, return = equal");
	}
}
