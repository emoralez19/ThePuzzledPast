using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class JigsawScript : MonoBehaviour
{
    [SerializeField] private Transform emptySpace = null;
    private Camera camera;
    [SerializeField] public TileScript[] tiles;
    [SerializeField] public TileScript[] tile;
    private int emptySpaceIndex = 9;
    private bool isFinished;
    [SerializeField] Text winMessage;
    [SerializeField] Text RoomHint;
    public GameObject button;
    public GameObject backPanel;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        Shuffle();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit)
            {
                if (Vector2.Distance(emptySpace.position, hit.transform.position)< 4)
                {
                    Vector2 lastEmptySpacePosition = emptySpace.position;
                    TileScript thisTile = hit.transform.GetComponent<TileScript>();
                    emptySpace.position = thisTile.TargetPosition;
                    thisTile.TargetPosition = lastEmptySpacePosition;
                    int tileIndex = findIndex(thisTile); 
                    tiles[emptySpaceIndex] = tiles[tileIndex];
                    tiles[tileIndex] = null;
                    emptySpaceIndex = tileIndex;
                }
            }
        }
        if (!isFinished)
        { 
            int correctTiles = 0;
            foreach (var a in tiles)
            {
                if (a != null)
                {
                    if (a.inRightPlace)
                    {
                        correctTiles++;
                        Debug.Log("Added one");
                    }
                    // Win State
                    if (correctTiles == tiles.Length - 1)
                    {
                        Debug.Log("In the win state");
                        isFinished = true;
                        Debug.Log("Finished true");
                        button.SetActive(true);
                        winMessage.text = "Puzzle Solved!!";
                        RoomHint.text = "Ada programming language";
                        backPanel.SetActive(true);
                    }
                }
            } 
        }
    }

    public void Shuffle()
    {
        if (emptySpaceIndex != 9)
        {
            var tileOn9LastPos = tiles[9].TargetPosition;
            tiles[9].TargetPosition = emptySpace.position;
            emptySpace.position = tileOn9LastPos;
            tiles[emptySpaceIndex] = tiles[9];
            tiles[9] = null;
            emptySpaceIndex = 9;
        }
        int invertion;
        do
        {
            for (int i = 0; i <= 7; i++)
            {
                var lastPos = tiles[i].TargetPosition;
                int randomIndex = UnityEngine.Random.Range(0, 7);
                tiles[i].TargetPosition = tiles[randomIndex].TargetPosition;
                tiles[randomIndex].TargetPosition = lastPos;
                var tile = tiles[i];
                tiles[i] = tiles[randomIndex];
                tiles[randomIndex] = tile;

            }
            invertion = GetInversions();
        } while (invertion % 2 != 0);
       
    }

    public int findIndex(TileScript ts)
    {
        for (int i =0; i < tiles.Length; i++) 
        {
            if (tiles[i] != null)
            {
                if (tiles[i] == ts)
                {
                    return i;
                }
            }
        }
        return -1;
    }

    int GetInversions()
    {
        int inversionsSum = 0;
        for (int i = 0; i < tiles.Length; i++)
        {
            int thisTileInversion = 0;
            for (int j = i; j < tiles.Length; j++)
            {
                if (tiles[j] != null)
                {
                    if (tiles[i].number > tiles[j].number)
                    {
                        thisTileInversion++;
                    }
                }
            }
            inversionsSum += thisTileInversion;
        }
        return inversionsSum;
    }
}
