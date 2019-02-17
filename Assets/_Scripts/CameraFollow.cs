using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField][Range(1f, 5f)] private float camFollowSpeed;
    [SerializeField] private Vector3 offset;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, camFollowSpeed * Time.deltaTime);
    }
}