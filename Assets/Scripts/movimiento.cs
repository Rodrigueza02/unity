using UnityEngine;

public class MovimientoSimple : MonoBehaviour
{
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * 5 * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * 5 * Time.deltaTime;
        transform.Translate(x, 0, z);
    }
}

