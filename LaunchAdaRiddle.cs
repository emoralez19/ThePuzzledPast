using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchAdaRiddle : MonoBehaviour
{
    public void LoadAdaRiddle()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Additive);
    }
}
