using System.Collections;
using System.Collections.Generic;
using Basics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "Patrol", menuName = "Ai/Function/Patrol")]
public class AntAiPatrol : AiBase
{
    [HideInInspector] public GameAction sendCoroutine;
    public GameAction addPointList;
    public FloatData distance, holdTime;

    public List<Vector3Data> PatrolPoints { private get; set; }

    private int i;
    
    private void OnEnable()
    {
        PatrolPoints?.Clear();
        if (addPointList != null) addPointList.Raise += AddPatrolPointList;
        i = 0;
    }

    private void AddPatrolPointList(object obj)
    {
        PatrolPoints = obj as List<Vector3Data>;
    }
    
    public override void RunAgent(NavMeshAgent agent)
    {
        Debug.Log(agent.remainingDistance);
        agent.SetDestination(PatrolPoints[i].Value);
        
        if (((agent.remainingDistance >= distance.value))) 
            return;
            
        if (i < PatrolPoints.Count - 1)
        {
            i++;
        }
        else
        {
            i = 0;
        }
    }
}