using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using TMPro;

public class WireCount : MonoBehaviour
{
    public int count;
    public TextMeshProUGUI winText;
    public TextMeshProUGUI RoomHint;
    private int onCount = 0;
    static public WireCount Instance;

    private void Awake()
    {
        Instance = this;
    }


    public void onChange(int points)
    {
        onCount = onCount + points;
        if (onCount == count)
        {
            winText.text = "Puzzle Solved!!";
            RoomHint.text = "Room Hint: Known as the inventor of the HTML markup language," +
                            "the URL system, and HTTP";
        }
    }
    
}
