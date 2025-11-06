using UnityEngine;

public class InstanciarPrefab : MonoBehaviour
{
    public GameObject prefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
