using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenHowTo : MonoBehaviour
{
    public void OpenHowToScene()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
