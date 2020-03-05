
using System.Collections.Generic;
using UnityEngine;

public class MatchIDBehaviour : MonoBehaviour
{
    public List<NameId> nameIds;
    private NameId otherIDObj;
    public List<DowWorkSO> Doworks;
    private void OnTriggerEnter(Collider other)
    {
        otherIDObj = other.GetComponent<BehaviourID>().nameIDObj;
        CheckID();
    }

    private void CheckID()
    {
        foreach (var obj in nameIds)
        {
            if (obj == otherIDObj)
            {
                foreach (var job in Doworks)
                {
                    job.Work();
                }
            }
        }
    }
}
