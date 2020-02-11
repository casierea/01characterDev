using UnityEngine;

public class LightChanger : MonoBehaviour {

    public GameObject light;
    private bool on = false;

    // Use this for initialization
    void OnTriggerStay(Collider plyr) {
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !on)
        {
            light.SetActive(true);
            on = true;
        }
        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && on)
            {
            light.SetActive(false);
            on = false;
        }
    }
}
