using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    Vector3 startPoint;
    public SpriteRenderer wireEnd;
    Vector3 startPosition;
    public GameObject lightOn;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.parent.position;
        startPosition = transform.position;
    }

    private void OnMouseDrag()
    {
        // mouse position to world point
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0;

        //check for nearby connection points
        Collider2D[] colliders = Physics2D.OverlapCircleAll(newPosition, 0.2f);
        foreach (Collider2D collider in colliders)
        {
            //make sure not my own collider
            if (collider.gameObject != gameObject)
            {
                //update wire to connection point position
                UpdateWire(collider.transform.position);

                //check if wires are the same color
                if (transform.parent.name.Equals(collider.transform.parent.name))
                {
                    //count connection
                    WireCount.Instance.onChange(1);

                    //finish step
                    collider.GetComponent<Wire>()?.Done();
                    Done();
                }

                return;
            }

        }

        //update wire
        UpdateWire(newPosition);

    }

    void Done()
    {
        //turn on light
        lightOn.SetActive(true);

        //destroy this script
        Destroy(this);
    }

    private void OnMouseUp()
    {
        //reset wire position
        UpdateWire(startPosition);
    }

    void UpdateWire(Vector3 newPosition)
        {
            //update wire position
            transform.position = newPosition;

            //update direction
            Vector3 direction = newPosition - startPoint;
            transform.right = direction * transform.lossyScale.x;

            //update scale
            float dist = Vector2.Distance(startPoint, newPosition);
            wireEnd.size = new Vector2(dist, wireEnd.size.y);
        }
        
}
