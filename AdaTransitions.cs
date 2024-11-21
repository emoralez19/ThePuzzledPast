using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdaTransitions : MonoBehaviour
{
    public void LoadAdaBio()
    {
        SceneManager.LoadSceneAsync(9);
    }
}
