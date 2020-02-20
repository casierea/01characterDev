using UnityEngine;
[CreateAssetMenu]
public class DebuggerSimp : ScriptableObject
{
    public void OnDebug(string message)
    {
        Debug.Log(message);
    }

    public void OnDebug(int number)
    {
        Debug.Log(number);
    }
}