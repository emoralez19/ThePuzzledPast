using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class movePiece : MonoBehaviour
{
    public string pieceStatus = "idle";
    public Transform edgeParticles;
    public KeyCode placePiece;
    public KeyCode returnToInv;
    public string checkPlacement = "";
    public Vector2 invPos;
    public int remainingPieces = 12;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        invControl();
        if (pieceStatus == "pickedup")
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }

        if ((Input.GetKeyDown(placePiece) && (pieceStatus == "pickedup")))
        {
            checkPlacement = "yes";
        }

        //Yippeee win!!!
        if(remainingPieces == 0)
        {

        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if ((other.gameObject.name == gameObject.name) && (checkPlacement == "yes"))
        {
            other.GetComponent<BoxCollider2D> ().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Renderer>().sortingOrder = 2;
            transform.position = other.gameObject.transform.position;
            pieceStatus = "locked";
            Instantiate(edgeParticles, other.gameObject.transform.position, edgeParticles.rotation);
            checkPlacement = "no";
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            remainingPieces -= 1;
        }

        if ((other.gameObject.name != gameObject.name) && (checkPlacement == "yes"))
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, .5f);
            checkPlacement = "no";
        }
    }

    void OnMouseDown()
    {
        pieceStatus = "pickedup";
        checkPlacement = "no";
        GetComponent<Renderer>().sortingOrder = 10;
        invPos = transform.position;
    }

    void invControl()
    {
        if ((Input.GetKeyDown(returnToInv)) && (pieceStatus == "pickedup"))
        {
            transform.position = new Vector2(invPos.x, invPos.y);
            pieceStatus = "";
        }
    }
}
