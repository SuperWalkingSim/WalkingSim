using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlfriendController : MonoBehaviour
{
    public Transform target;

    //Amount of smoothing applied to camera follow
    public float smoothSpeed;

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (target)
        {
            //Lerp function used to determine the line between the camera's position and the target's position.
            Vector3 desiredPosition = target.position + offset;
            //Vector3 desiredPosNoY = new Vector3(desiredPosition.x, transform.position.y, desiredPosition.z);
            //Smoothing multiplied by time in order to add the smoothing speed at every frame.
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
    }
}
