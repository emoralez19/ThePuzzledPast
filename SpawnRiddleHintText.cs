using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnRiddleHintText : MonoBehaviour
{
    [SerializeField] Text RiddleHintText;
    public GameObject button;

    public void spawnText()
    {
        RiddleHintText.text = "Hint: A self contained module of code that accomplishes a specific task"; 
    }
}
