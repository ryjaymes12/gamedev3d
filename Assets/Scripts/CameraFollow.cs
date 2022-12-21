using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 offset; 

    private void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 targetPos = player.position + offset;
        targetPos.x = 0;
        transform.position = targetPos;
    }
}
