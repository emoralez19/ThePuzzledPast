using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraceRiddleHandler : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] Text resultText;
    [SerializeField] Text hintText;
    public GameObject button;

    public void ValidateInput()
    {
        string input = inputField.text;

        if ((input.Equals("Keyboard")) | (input.Equals("keyboard")))
        {
            resultText.text = "Correct!";
            resultText.color = Color.green;
            hintText.text = "Room Hint: Computer Pioneer and Naval Officer";
            button.SetActive(true);
        }
        else if (input.Length < 0)
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

    [SerializeField] Text RiddleHintText;
    public GameObject HintButton;

    public void spawnText()
    {
        RiddleHintText.text = "Hint: Used to input information into a computer";
    }
}
