using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.transform.position;
    }
}
