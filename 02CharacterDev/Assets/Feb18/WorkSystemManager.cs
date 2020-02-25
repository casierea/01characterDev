using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

[CreateAssetMenu]

public class WorkSystemManager : ScriptableObject
{
    [Serializable]
   
    public struct possibleWork
    {
        public NameID nameIdObj;
        public WorkSystem worksystemObj;
        public UnityEvent workEvent;
        // go to MatchIdbehaviour script and ass in obj.event.boop
    }

    public List<possibleWork> workIdList;
}
