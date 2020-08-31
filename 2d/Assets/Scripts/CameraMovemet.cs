using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovemet : MonoBehaviour
{
    public float speed = 20f;

    public float ScreenEnde = 10f;

    public Vector2 StopCamera;

    public float scrollspeed = 2f;

    public float MaxScroll = 120f;

    public float MinScroll = 40f;

    void Update()

    {

        Vector3 pos = transform.position;



        if (Input.GetKey(KeyCode.W) || Input.mousePosition.y >= Screen.height - ScreenEnde)

        {

            pos.y += speed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.S) || Input.mousePosition.y <= ScreenEnde)

        {

            pos.y -= speed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.A) || Input.mousePosition.x <= ScreenEnde)

        {

            pos.x -= speed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.D) || Input.mousePosition.x >= Screen.width - ScreenEnde)

        {

            pos.x += speed * Time.deltaTime;

        }



        float scroll = Input.GetAxis("Mouse ScrollWheel");

        pos.z += scroll * scrollspeed * 100f * Time.deltaTime;



        pos.x = Mathf.Clamp(pos.x, -StopCamera.x, StopCamera.x);

        pos.y = Mathf.Clamp(pos.y, -StopCamera.y, StopCamera.y);

        pos.z = Mathf.Clamp(pos.z, -MaxScroll, MinScroll);



        transform.position = pos;

    }
}
