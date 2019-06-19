using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Global variables
        int maxGuess = 1000; 
        int minGuess = 1;
        int guess = 500;

    // Start is called before the first frame update
    void Start()
    {


        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick a number");
        Debug.Log("Highest: " + maxGuess);
        Debug.Log("Lowest: " + minGuess);
        Debug.Log("Tell me if your number is higher or lower than 500.");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
            {
                Debug.Log("Up Arrow key was pressed.");
                minGuess = guess;
                guess = (maxGuess + minGuess) / 2;
                Debug.Log(guess);
            }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) 
            {
                Debug.Log("Down Arrow key was pressed.");
                maxGuess = guess;
                guess = (maxGuess + minGuess) / 2;
                Debug.Log(guess);
            }
        else if (Input.GetKeyDown(KeyCode.Return)) 
            {
                Debug.Log("Return key was pressed.");
            }
    }
}
