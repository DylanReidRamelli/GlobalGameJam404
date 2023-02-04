using UnityEngine;
using System.Collections;

public class Camera_follow : MonoBehaviour
{
    public Transform target;
    public float smooth = 5.0f;
    void Update()
    {
        transform.position = Vector3.Lerp(
            transform.position, target.position,
            Time.deltaTime * smooth);
    }

}
