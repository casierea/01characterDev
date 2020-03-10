using UnityEngine;
using UnityEngine.Events;

public class OnTriggerBehaviour : MonoBehaviour
{
    public UnityEvent Event;
    public UnityEvent<Collider> colliderEvent;

    private void OnTriggerEnter(Collider other)
    {
        Event.Invoke();
    }
}
