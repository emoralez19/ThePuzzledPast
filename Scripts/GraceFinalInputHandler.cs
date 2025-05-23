using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraceFinalInputHandler : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] Text resultText;
    public GameObject button;

    public void ValidateFinalInput()
    {
        string input = inputField.text;

        if ((input.Equals("Grace Hopper")) | (input.Equals("grace hopper")))
        {
            resultText.text = "Correct!";
            resultText.color = Color.green;
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
}
