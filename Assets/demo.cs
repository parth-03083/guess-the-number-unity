using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class demo : MonoBehaviour
{


    public InputField input;
    public Text infoText;
    private int guessNum;
    private int userGuess;
    void Start()
    {
     guessNum=Random.Range(0,100);
    }
    
    public void chkGs(){
        userGuess=int.Parse(input.text);
        if(userGuess==guessNum){
             infoText.text="Your Guess is correct....!";
        }

        else if(userGuess<guessNum){
             infoText.text="Your Guess is lower than number....!";
        }

        else if(userGuess>guessNum){
             infoText.text="Your Guess is higher than correct....!";
        }
    }
}
