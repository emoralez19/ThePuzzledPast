using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BernersFinalInputHandler : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] Text resultText;
    public GameObject button;

    public void ValidateFinalInput()
    {
        string input = inputField.text;

        if ((input.Equals("sir tim berners lee")) | (input.Equals("Sir Tim Berners-Lee")) | (input.Equals("sir tim berners-lee")) | (input.Equals("TimBL")) | (input.Equals("tim bl")))
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
