using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform player;

    public Vector2 minPosition;

    public Vector3 maxPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    Vector3 desiredPosition = player.position + new Vector3 (0,0,-10); 

    float clampX = Mathf.Clamp(desiredPosition.x, minPosition.x, maxPosition.x);
    float clampY = Mathf.Clamp(desiredPosition.y, minPosition.y, maxPosition.y);

    Vector3 clampedPosition = new Vector3(clampX, clampY, desiredPosition.z);

    transform.position = clampedPosition;
    
    }
}
