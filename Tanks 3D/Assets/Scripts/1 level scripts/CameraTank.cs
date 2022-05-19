using System.Collections;
using UnityEngine;

public class CameraTank : MonoBehaviour
{
    public Transform target;
 
    void FixedUpdate()
    {
        transform.LookAt(target);
    }
}
