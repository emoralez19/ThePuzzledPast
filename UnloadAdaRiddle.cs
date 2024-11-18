using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnloadAdaRiddle : MonoBehaviour
{
    public void CloseAdaRiddle()
    {
        SceneManager.UnloadSceneAsync(4);
    }
}
