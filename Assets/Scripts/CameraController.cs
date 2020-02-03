using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 camMove;
    public  GameObject target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        camMove.x = target.transform.position.x;
        camMove.y = target.transform.position.y;
        camMove.z = gameObject.transform.position.z;

        gameObject.transform.position = camMove;
    }
}
