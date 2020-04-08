using UnityEngine;
using UnityEngine.Events;

public class BoolCheckIt : MonoBehaviour
{
    public FloatData Inventory;
    public float check;
    public UnityEvent Open;
    public UnityEvent Warning;

    public void CheckForItem ()
    {
        if (Inventory.value >= check)
        {
            Open.Invoke();
        }

        else
        {
            Warning.Invoke();
        }
    }

}