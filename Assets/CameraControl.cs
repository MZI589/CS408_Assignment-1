using System.Collections;
using System.Collections.Generic;
using UnityEngine;
     // CREATIVE FEATURE
public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("ham").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = player.position + new Vector3 (0, 30.0f, -50f);
        transform.position = Vector3.Slerp (transform.position, targetPos, 30.0f * Time.deltaTime);
        Quaternion targetRotation = Quaternion.LookRotation (player.position - transform.position);
        transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, 30.0f * Time.deltaTime);
    }
}
