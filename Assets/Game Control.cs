using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    int minNumber = 1;
    int maxNumber = 100;
    int guess;
    bool gameStarted = false;
    bool gameFinised = false;
    // Start is called before the first frame update
    void Start()
    {
        print("Would you like to play a game with me? (Y/N)");
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameStarted) { 
        // Baslangic ================
        if (Input.GetKeyDown(KeyCode.Y))
        {
            print("Great! Pick a number between 1 and 100 and press Enter!");
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            print("You Know!");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Control();
                gameStarted = true;
        }
        // Baslangic ================
        } else if (!gameFinised) 
        {

        // Oyun ================
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
                minNumber = guess;
            Control();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
                maxNumber = guess;
            Control();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            print("That's great! I found the number in your mind!");
                gameFinised =true;
        }
        // Oyun ================
        }
    }
    void Control()
    {
        guess = (minNumber + maxNumber) / 2;
        print("Is the number you have in mind " + guess + "? If it's larger, press the up arrow, if it's smaller, press the down arrow! If it's correct, press the spacebar!");
    }
}
