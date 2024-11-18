using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLevelSelection : MonoBehaviour
{
    public void OpenLevelSelectionScene()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
