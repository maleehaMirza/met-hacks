using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterviewQuiz : MonoBehaviour
{
    [SerializeField] Button Choice1;
    [SerializeField] Button Choice2;
    [SerializeField] Button Choice3;
    [SerializeField] Button Choice4;

    public Text charName;
    public Text description;

    public int NumQuestion;
    private int CurrentQuestion = 0;
    private int NumCorrect = 0;
    private bool pass = false;

    public string[] QuestionTitle;
    public string[] Questions;
    
    // Start is called before the first frame update
    void Start()
    {
        //when button is clicked, "listen" for particular method
        Choice1.onClick.AddListener(CheckIfCorrect1);
        Choice2.onClick.AddListener(CheckIfCorrect2);
        Choice3.onClick.AddListener(CheckIfCorrect3);
        Choice4.onClick.AddListener(CheckIfCorrect4);
    }

    //Celiac, Overgrowth, Floral (B,C,D)

    private void CheckIfCorrect1()
    {
        NumCorrect += 0;

        NextQuestion();
        return;
    }

    private void CheckIfCorrect2()
    {
        if(CurrentQuestion == 0)
        {
            NumCorrect += 1;
        }
        else
        {
            NumCorrect += 0;
        }

        NextQuestion();
        return;
       
    }

    private void CheckIfCorrect3()
    {
        if(CurrentQuestion == 1)
        {
            NumCorrect += 1;
        }
        else
        {
            NumCorrect += 0;
        }

        NextQuestion();
        return;
    }

    private void CheckIfCorrect4()
    {
        if(CurrentQuestion == 2)
        {
            NumCorrect += 1;
        }
        else
        {
            NumCorrect += 0;
        }

        NextQuestion();
        return;
    }

    public void NextQuestion()
    {
        if(CurrentQuestion == NumQuestion-1)
        {
            if(NumCorrect >= 2)
            {
                pass = true;
            }

            LoadResults(pass);
            return;
        }


    }
    
    public void LoadResults(bool pass)
    {
        // if(pass == false)
        // {
        //     SpriteManager.
        // }
        // else
        // {

        // }

        return;

    }

    
}
