using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchAdaJigsaw : MonoBehaviour
{
    public void LoadAdaJigsaw()
    {
        SceneManager.LoadSceneAsync(5);
    }
}
