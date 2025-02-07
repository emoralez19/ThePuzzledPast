using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BernersRiddleHandler : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] Text resultText;
    [SerializeField] Text hintText;
    public GameObject button;

    public void ValidateInput()
    {
        string input = inputField.text;

        if ((input.Equals("Virus")) | (input.Equals("virus")))
        {
            resultText.text = "Correct!";
            resultText.color = Color.green;
            hintText.text = "Room Hint: Published the first website";
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
        RiddleHintText.text = "Hint: Harmful computer program";
    }
}
