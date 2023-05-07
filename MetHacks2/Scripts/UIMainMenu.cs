using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //to get UI methods

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _startGame;

    // Start is called before the first frame update
    void Start()
    {
        //when button is clicked, "listen" for particular method
        _startGame.onClick.AddListener(StartNewGame);
    }

    //reference scenesmanager custom class
    private void StartNewGame()
    {
        ScenesManager.Instance.LoadNewGame();
        //how to use w loadscene
        //LoadScene(SceneManager.Scene.[scenename])
    }
}
