using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CellCameraController : MonoBehaviour
{
    [SerializeField]
    Transform player;

    float distToCornerX;
    float distToCornerY;
    // Start is called before the first frame update
    void Start()
    {
        Camera cam = GetComponent<Camera>();
        Vector3 camCorner = cam.ViewportToWorldPoint(new Vector3(1, 1, cam.nearClipPlane));
        distToCornerX = camCorner.x - transform.position.x;
        distToCornerY = camCorner.y - transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float horInput = Mathf.Sign(Input.GetAxis("Horizontal"));
        float verInput = Mathf.Sign(Input.GetAxis("Vertical"));

        float newX = transform.position.x;

        if (distToCornerX < Mathf.Abs(player.position.x) - Mathf.Abs(transform.position.x))
        {
            newX = distToCornerX * 2 * horInput + transform.position.x;
        }

        float newY = transform.position.y;

        if (distToCornerY < Mathf.Abs(player.position.y) - Mathf.Abs(transform.position.y))
        {
            newY = distToCornerY * 2 * horInput + transform.position.y;
        }

        transform.position = new Vector3(newX, newY, -10);
    }
}
