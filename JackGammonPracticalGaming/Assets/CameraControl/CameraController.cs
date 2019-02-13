using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position - player.transform.forward * offset.z + offset.y * Vector3.up;

        transform.LookAt(player.transform.position);

    }

}