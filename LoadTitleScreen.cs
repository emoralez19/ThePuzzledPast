using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTitleScreen : MonoBehaviour
{
    public void BackHome()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
