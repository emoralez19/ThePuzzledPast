using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] Text resultText;
    [SerializeField] Text hintText;
    public GameObject button;

    public void ValidateInput()
    {
        string input = inputField.text;

        if ((input.Equals("Function")) | (input.Equals("function") ))
        {
            resultText.text = "Correct!";
            resultText.color = Color.green;
            hintText.text = "Room Hint: Inspired Alan Turing during his work on the first modern computers";
            button.SetActive(true);
        }
        else if ( input.Length < 0 ) 
        {
            resultText.text = "Invalid input";
            resultText.color = Color.red;
        }
        else
        {
            resultText.text = "Incorrect. Try again.";
            resultText.color = Color.red;
        }
    }
}
