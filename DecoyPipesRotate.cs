using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoyPipesRotate : MonoBehaviour
{
    float[] rotations = { 0, 90, 180, 270 };
    public float[] correctRotation;
    int PossibleRotations = 1;

    // Start is called before the first frame update
    void Start()
    {
        PossibleRotations = correctRotation.Length;
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
    }

    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 90));

    }
}
