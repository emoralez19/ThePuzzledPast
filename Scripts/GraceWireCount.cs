using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using TMPro;

public class GraceWireCount : MonoBehaviour
{
    public int count;
    public TextMeshProUGUI winText;
    public TextMeshProUGUI RoomHint;
    private int onCount = 0;
    static public GraceWireCount Instance;

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
            RoomHint.text = "Room Hint: Hopper";
        }
    }
    
}
