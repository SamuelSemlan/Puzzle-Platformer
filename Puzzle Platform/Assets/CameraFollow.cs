using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    public Vector3 offset;
    public float smoothSpeed = 0.12f;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
        
    }
}
