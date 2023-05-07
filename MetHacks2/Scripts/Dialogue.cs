using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//dialogue class
[System.Serializable]
public class Dialogue
{
    public string name; //character name

    //3 = min number of lines for text area. 
    //10 = max number of lines for text area.
    [TextArea(3, 10)]
    public string[] sentences; //dialogue sentences


}
