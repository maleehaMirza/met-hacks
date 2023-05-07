using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//access to namespace with classes that have to do w changing scenes
using UnityEngine.SceneManagement; 

public class ScenesManager : MonoBehaviour
{
    //access class from any script w/out 
    //having to reference class first
    //Only one version of it. A top level 
    //class to handle the scenes
    public static ScenesManager Instance;

    private void Awake()
    {
        Instance = this; //equal to this class
    }

    //list of indexed constants
    //make sure ordering in enum is same as build settings
    public enum Scene
    {
        MainMenu,
        Introduction,
        IntroScenario,
        IntroDialogue,
        BobAndGreenie,
        Interview
    }

    public void LoadScene(Scene scene)
    {
        //SceneManager from Unity SceneManager
        SceneManager.LoadScene(scene.ToString());
        
    }

    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.Introduction.ToString());
    }

    public void LoadNextScene()
    {
        //load next scene in enum by getting index of current scene + 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void LoadPrevScene()
    {
        //load next scene in enum by getting index of current scene + 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

    //load the main menu
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.MainMenu.ToString());

    }


}   

