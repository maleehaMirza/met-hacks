using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //to get UI methods 

public class UIIntroductionArrows : MonoBehaviour
{
    //create fields for buttons
    [SerializeField] Button _nextPerson;
    [SerializeField] Button _prevPerson;

    public Text charName;
    public Text description;
    private int current = 0;

    public List<string> character;

    [TextArea(3,15)]
    public List<string> descriptions;

 
   
    // Start is called before the first frame update
    void Start()
    {
        //when button is clicked, "listen" for particular method
        _nextPerson.onClick.AddListener(displayNextText);
        _prevPerson.onClick.AddListener(displayPrevText);
    }

    //reference scenesmanager custom class
    private void displayNextText()
    {
        //if last description
        if(current == character.Count-1)
        {
            EndCharIntro();
            return;
        }

        Debug.Log("Current number: " + current);    
        current += 1;
        charName.text = character[current];
        description.text = descriptions[current];

    }

     //reference scenesmanager custom class
    private void displayPrevText()
    {
        //if first description
        if(current == 0)
        {
            toMainMenu();
            return;
        }

        current -= 1;
        charName.text = character[current];
        description.text = descriptions[current];
    }

    void EndCharIntro()
    {
        ScenesManager.Instance.LoadNextScene();
    }

    void toMainMenu()
    {
        ScenesManager.Instance.LoadPrevScene();
    }
}
