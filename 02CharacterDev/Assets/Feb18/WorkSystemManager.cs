using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[CreateAssetMenu]

public class WorkSystemManager : ScriptableObject
{
    [Serializable]
   
    public struct possibleMatches
    {
        public NameID nameIdObj;
        public WorkSystem worksystemObj;
    }

    public List<possibleMatches> workIdList;
}
