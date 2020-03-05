using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class string02 : ScriptableObject
{     //exxperiment for StringDataList in class. 
    public List<string> stringListObj;

    public int currentLineNumber;
    //whatever this is in the editot, it will calll that line

    public string ReturnCurrentLine()   //being called constantly. being called by text obj.
    {
        return stringListObj[currentLineNumber];
    }

    public void LineNumber()  //being called by button
    {
        if (currentLineNumber < stringListObj.Count-1)
        {
            currentLineNumber = 0;
        }
        else
        {
            currentLineNumber = 0;
        }
        
    }
}