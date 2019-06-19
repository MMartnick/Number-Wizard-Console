using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Global variables
        int maxGuess; 
        int minGuess;
        int guess;

    // Start is called before the first frame update by the Unity engine
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {

        maxGuess = 1000; 
        minGuess = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick a number");
        Debug.Log("Highest: " + maxGuess);
        Debug.Log("Lowest: " + minGuess);
        Debug.Log("Tell me if your number is higher or lower than 500.");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        maxGuess = maxGuess + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
            {
                minGuess = guess;
                NextGuess();
            }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) 
            {
                maxGuess = guess;
                NextGuess();
            }
        else if (Input.GetKeyDown(KeyCode.Return)) 
            {
                Debug.Log("Return key was pressed.");
                StartGame();
            }
    }

    void NextGuess()
    {
        guess = (maxGuess + minGuess) / 2;
        Debug.Log("Is it higher or lower than " + guess);
    }
}
