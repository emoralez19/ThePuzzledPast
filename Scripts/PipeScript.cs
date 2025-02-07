using UnityEngine;

public class PipeScript : MonoBehaviour
{
    float[] rotations = {0, 90, 180, 270 };
    public float[] correctRotation;
    [SerializeField] bool isPlaced = false;
    int PossibleRotations=1;
    PipesManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<PipesManager>();
    }

    private void Start()
    {
        PossibleRotations = correctRotation.Length;
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);

        if (PossibleRotations >1)
        {
            if (transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1])
            {
                isPlaced = true;
                gameManager.correctMove();
            }
        }
        else
        {
            if (transform.eulerAngles.z == correctRotation[0])
            {
                isPlaced = true;
                gameManager.correctMove();
            }
        }
       
        
    }


    private void OnMouseDown()
    {
        transform.Rotate(new Vector3 (0,0,90));

        if (PossibleRotations >1)
        {
            if (transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1] && isPlaced == false)
            {
                isPlaced = true;
                gameManager.correctMove();
            }
            else if (isPlaced == true)
            {
                isPlaced = false;
                gameManager.wrongMove();
            }
        }
        else
        {
            if (transform.eulerAngles.z == correctRotation[0] && isPlaced == false)
            {
                isPlaced = true;
                gameManager.correctMove();
            }
            else if (isPlaced == true)
            {
                isPlaced = false;
                gameManager.wrongMove();
            }
        }
            
      
      
    }
}
