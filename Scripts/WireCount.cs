using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class WireCount : MonoBehaviour
{
    public int count;
    public GameObject winText;
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
            winText.SetActive(true);
        }
    }
    
}
