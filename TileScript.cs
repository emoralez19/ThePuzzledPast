using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour
{
    public Vector3 TargetPosition;
    private Vector3 correctPosition;
    private SpriteRenderer sprite;
    public int number;
    public bool inRightPlace;

    // Start is called before the first frame update
    void Awake()
    {
        TargetPosition = transform.position;
        correctPosition = transform.position;
        sprite = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, TargetPosition, 0.05f);
        if (TargetPosition == correctPosition)
        {
            sprite.color = Color.green;
            inRightPlace = true;
        }
        else
        {
            sprite.color = Color.cyan;
            inRightPlace = false;
        }
    }

   
}
