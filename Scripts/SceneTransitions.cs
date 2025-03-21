using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{

    //Ada Lovelace

    public void LoadAdaRiddle()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Additive);
    }

    public void OpenAdaScene()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void LoadAdaJigsaw()
    {
        SceneManager.LoadSceneAsync(5);
    }
    public void LoadAda9()
    {
        SceneManager.LoadScene(6);
    }

    public void CloseAdaRiddle()
    {
        SceneManager.UnloadSceneAsync(4);
    }

    public void LoadAdaFinal()
    {
        SceneManager.LoadSceneAsync("AdaFinalAnswer");
    }
    public void LoadAdaBio()
    {
        SceneManager.LoadSceneAsync(9);
    }

    public void LoadAdaPipes()
    {
        SceneManager.LoadScene(7);
    }


    //Grace Hopper

    public void LoadGraceLevelNow()
    {
        SceneManager.LoadSceneAsync("GraceH_Level");
    }

    public void LoadGraceRiddle()
    {
        SceneManager.LoadSceneAsync("GraceRiddle", LoadSceneMode.Additive);
    }

    public void LoadGraceMemory()
    {
        SceneManager.LoadSceneAsync("GraceMemory", LoadSceneMode.Additive);
    }

    public void LoadGrace9()
    {
        SceneManager.LoadSceneAsync("Grace9Puzzle");
    }

    public void LoadGraceWire()
    {
        SceneManager.LoadSceneAsync("GraceWires");
    }

    public void LoadGraceFinal()
    {
        SceneManager.LoadSceneAsync("GraceFinalAnswer");
    }

    public void LoadGraceBio()
    {
        SceneManager.LoadSceneAsync("GraceBio");   
    }



    //Alan Turing
    public void LoadTuringNow()
    {
        SceneManager.LoadSceneAsync("Turing_Level");
    }

    public void LoadTuringRiddle()
    {
        SceneManager.LoadSceneAsync("TuringRiddle", LoadSceneMode.Additive);
    }

    public void LoadTuringSlide()
    {
        SceneManager.LoadSceneAsync("TuringSlidePuzzle");
    }

    public void LoadTuringJigsaw()
    {
        SceneManager.LoadSceneAsync("TuringJigsaw");
    }

    public void LoadTuringExtra()
    {

    }

    public void LoadTuringFinal()
    {
        SceneManager.LoadSceneAsync("TuringFinalAnswer");
    }

    public void LoadTuringBio()
    {
        SceneManager.LoadSceneAsync("TuringBio");
    }


    //Tim Berners-Lee

    public void LoadBernersNow()
    {
        SceneManager.LoadSceneAsync("Berners-Lee_Level");
    }


    public void LoadConnectingWires()
    {
        SceneManager.LoadSceneAsync("ConnectingWires");
    }

    public void LoadBernersJigsaw()
    {
        SceneManager.LoadSceneAsync("BernersJigsaw");
    }

    public void LoadBernersRiddle()
    {
        SceneManager.LoadSceneAsync("BernersRiddle", LoadSceneMode.Additive);
    }

    public void LoadBernersPipes()
    {
        SceneManager.LoadSceneAsync("BernersPipes");
    }

    public void LoadBernersFinal()
    {
        SceneManager.LoadSceneAsync("BernersFinalAnswer");
    }

    public void LoadBernersBio()
    {
        SceneManager.LoadSceneAsync("BernersBio");
    }

    // generic
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


    public void QuitGameNow()
    {
        Application.Quit();
    }



    public void LoadTitle()
    {
        SceneManager.LoadScene(0);
    }
}
