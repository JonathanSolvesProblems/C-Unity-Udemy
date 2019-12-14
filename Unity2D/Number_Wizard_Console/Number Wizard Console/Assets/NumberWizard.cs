using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start() // runs when game first runs (initializes)
    {
        StartGame();
        
    }

    void StartGame()
    {
        // resetting for loop
        max = 1000;
        min = 1;
        guess = 500;

        // Debug.Log gives more flexibility and control than print
        Debug.Log("Welcome to the Number Wizard Game. I followed the tutorials" +
            "from the Unity Developer course on Udemy by Ben Tristem and Rick Davidson.");
        Debug.Log("Pick a number (I do not know what it is): ");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lower number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame

    /*
     * Better to put input into Update, since will be ignored in Start
     */

    // Update is called once per frame  
    void Update()
    {
        // Outer method looks for key, takes in another key as an argumen, and if pressed, then true
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
            
        }
        else if (Input.GetKeyDown(KeyCode.Return)) // return is enter key
        {
            Debug.Log("I am a genius!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }
}