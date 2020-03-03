using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class StringListData : ScriptableObject
{
    public List<string> stringListObj;

    public int currentLineNumber;
    //whatever this is in the editot, it will calll that line

    public string ReturnCurrentLine()
    {
        return stringListObj[currentLineNumber];
    }

    public void LineNumber()
    {
        if (currentLineNumber < stringListObj.Count-1)
        {
            currentLineNumber++;
        }
        else
        {
            currentLineNumber = 0;
        }
        
    }
}
