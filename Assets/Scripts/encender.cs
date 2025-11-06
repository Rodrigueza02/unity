using UnityEngine;

public class LuzOnOff : MonoBehaviour
{
    public Light luz;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
            luz.enabled = !luz.enabled;
    }
}
