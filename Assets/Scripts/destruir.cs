using UnityEngine;

public class Autodestruir : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3f);
    }
}
