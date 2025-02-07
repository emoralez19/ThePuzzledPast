using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipesManager : MonoBehaviour
{
    public GameObject PipesHolder;
    public GameObject[] Pipes;
    public int totalPipes = 0;
    [SerializeField] int correctPipes = 0;
    [SerializeField] Text winMessage;
    [SerializeField] Text RoomHint;
    public GameObject backPanel;

    // Start is called before the first frame update
    void Start()
    {
        totalPipes = PipesHolder.transform.childCount;
        Pipes = new GameObject[totalPipes];

        for (int i = 0; i < Pipes.Length; i++)
        {
            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;
        }
    }

    public void correctMove()
    {
        correctPipes++;
        Debug.Log("Correct move");

        if (correctPipes == totalPipes)
        {
            Debug.Log("Yay");
            winMessage.text = "Puzzle Solved!!";
            RoomHint.text = "This person is known as the first computer programmer";
            backPanel.SetActive(true);
        }
    }

    public void wrongMove()
    {
        correctPipes--;
    }
}
