using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    public void LoadTuringNow()
    {
        SceneManager.LoadSceneAsync("Turing_Level");
    }

    public void LoadTuringRiddle()
    {
        SceneManager.LoadSceneAsync("TuringRiddle");
    }

    public void LoadTuringSlide()
    {
        SceneManager.LoadSceneAsync("TuringSlidePuzzle");
    }

    public void LoadAdaBio()
    {
        SceneManager.LoadSceneAsync(9);
    }

    //load ada 9 puzzle
    public void LoadAda9()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadAdaFinal()
    {
        SceneManager.LoadSceneAsync("AdaFinalAnswer");
    }

    public void LoadAdaJigsaw()
    {
        SceneManager.LoadSceneAsync(5);
    }

    public void LoadAdaRiddle()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Additive);
    }

    public void OpenAdaScene()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void LoadBernersNow()
    {
        SceneManager.LoadSceneAsync("Berners-Lee_Level");
    }

    public void LoadConnectingWires()
    {
        SceneManager.LoadSceneAsync("ConnectingWires");
    }

    public void LoadGraceLevelNow()
    {
        SceneManager.LoadSceneAsync("GraceH_Level");
    }

    public void LoadGraceRiddle()
    {
        SceneManager.LoadSceneAsync("GraceRiddle");
    }

    public void BackHome()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void GoNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ReturnToPreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void OpenHowToScene()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void OpenLevelSelectionScene()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void CloseAdaRiddle()
    {
        SceneManager.UnloadSceneAsync(4);
    }

    public void QuitGameNow()
    {
        Application.Quit();
    }

    public void LoadAdaPipes()
    {
        SceneManager.LoadScene(7);
    }

    public void LoadTitle()
    {
        SceneManager.LoadScene(0);
    }
}
