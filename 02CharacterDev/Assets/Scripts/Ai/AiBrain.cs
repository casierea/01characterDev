using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "AiBrain", menuName = "Ai/Brain")]
public class AiBrain : ScriptableObject
{
    public AiBase aiBaseObj;

    public void ChangeBase(AiBase obj)
    {
        aiBaseObj = obj; //aibase is = to incomming obj.
    }

    public void Navigate(NavMeshAgent agent)
    {
        aiBaseObj.RunAgent(agent);
    }
}