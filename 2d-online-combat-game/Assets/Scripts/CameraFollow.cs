using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yOffSet = 1f;
    public Transform target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("PrototypeHeroNew(Clone)").transform;
    }

    private void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y + yOffSet, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
    }



}



