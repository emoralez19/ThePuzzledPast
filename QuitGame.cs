using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // used with OnClick() to exit game application
    public void QuitGameNow()
    {
        Application.Quit();
    }
}
