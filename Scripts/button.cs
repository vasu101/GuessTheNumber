using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class button : MonoBehaviour
{
    public TMP_InputField userInput;
    public TMP_Text gameLabel;
    public Button buttonGame ;
    private int newNum;
    public int minValue;
    public int maxValue;
    private bool isGameWon = false;
    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
    }
    private void ResetGame()
    {
        if (isGameWon)
        {
            gameLabel.text = "You won!, Guess a number between " + minValue + " and " + maxValue;
            isGameWon=false;
        }
        else 
        {
            gameLabel.text = "Guess a number between " + minValue + " and " + maxValue;
        }
        userInput.text = "";
        newNum = GetRandomNumber(minValue, maxValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void diplay() 
    {
        string userInputField = userInput.text;
        if (userInputField != "")
        {
            int answer = int.Parse(userInputField);
            if (answer == newNum) { gameLabel.text = "You win,." + answer + ".";
                //buttonGame.interactable = false;
                isGameWon =true;
                ResetGame();
            }
            else if (answer < newNum) { gameLabel.text = "Try something bigger."; }
            else if (answer > newNum) { gameLabel.text = "Try something smaller"; }
        }
        else { gameLabel.text = "Enter some value to proceed in game."; }
    }

    public int GetRandomNumber(int min, int max)
    {
        int random = Random.Range(min, max);
        return random;
    }
    
}


