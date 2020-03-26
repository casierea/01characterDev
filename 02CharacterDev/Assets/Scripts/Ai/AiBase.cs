using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

public abstract class AiBase : ScriptableObject
{
    public FloatData speed;
    public FloatData angularSpeed;
    public abstract IEnumerator Nav(NavMeshAgent ai);

    public abstract void RunAgent (NavMeshAgent agent);
}