using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TuringJisawManage : MonoBehaviour
{
    [SerializeField] int remainingPieces =12;
    //For win status
    [SerializeField] Text WinText;
    [SerializeField] Text hintText;
    [SerializeField] List<movePiece> Pieces;


    // Update is called once per frame
    void Update()
    {
        //Yippeee win!!!
        if (remainingPieces == 0)
        {
            WinText.text = "Yay! You solved the puzzle!";
            WinText.color = Color.black;
            hintText.text = "Room Hint: Turing";
        }
    }

    private void OnEnable()
    {
        foreach (var piece in Pieces)
        {
            piece.PieceSelected += subtractFromTotalPieces;
        }
    }

    private void subtractFromTotalPieces()
    {
        remainingPieces = remainingPieces-1;
        Debug.Log(remainingPieces);
        Debug.Log("Subtracted one");
    }
}
