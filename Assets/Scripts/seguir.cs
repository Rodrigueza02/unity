using UnityEngine;

public class SeguirObjeto : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 5f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, objetivo.position, velocidad * Time.deltaTime);
    }
}
