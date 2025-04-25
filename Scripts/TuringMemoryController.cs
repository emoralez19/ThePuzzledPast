using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TuringMemoryController : MonoBehaviour
{
    [SerializeField] TuringMemoryCard cardPrefab;
    [SerializeField] Transform cardContainer;
    [SerializeField] Sprite[] sprites;
    private List<Sprite> pairs;
    TuringMemoryCard firstSelected;
    TuringMemoryCard secondSelected;
    int matchCounts;
    [SerializeField] Text winText;
    [SerializeField] Text RoomHint;


    private void Start()
    {
        PrepareSprites();
        CreateCards();
    }


    private void PrepareSprites()
    {
        pairs = new List<Sprite>();
        for (int i = 0; i < sprites.Length; i++)
        {
            pairs.Add(sprites[i]);
            pairs.Add(sprites[i]);
        }
        Shuffle(pairs);
    }


    void CreateCards()
    {
        for (int i = 0; i < pairs.Count; i++)
        {
            TuringMemoryCard card = Instantiate(cardPrefab, cardContainer);
            card.SetIconSprite(pairs[i]);
            card.controller = this;
        }
    }


    public void SetSelected(TuringMemoryCard card)
    {
        if (card.isSelected == false)
        {
            card.Show();

            if (firstSelected == null)
            {
                firstSelected = card;
                return;
            }
            
            if(secondSelected == null)
            {
                secondSelected = card;
                StartCoroutine(CheckMatch(firstSelected, secondSelected));
                firstSelected = null;
                secondSelected = null;
            }
        }
       
    }


    IEnumerator CheckMatch(TuringMemoryCard a, TuringMemoryCard b)
    {
        yield return new WaitForSeconds(0.3f);
        if (a.visibleIcon == b.visibleIcon)
        {
            //matched
            matchCounts++;
            if (matchCounts >= pairs.Count /2)
            {
                //Yay win!!
                winText.text = "Yay! Minigame Complete!!";
                RoomHint.text = "Room Hint: Alan";
            }
        }
        else
        {
            //flip them back
            a.Hide();
            b.Hide();
        }
    }



        void Shuffle(List<Sprite> spriteList)
    {
        for (int i = spriteList.Count - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            Sprite temp = spriteList[i];

            spriteList[i] = spriteList[randomIndex];
            spriteList[randomIndex] = temp;
        }

    }



}