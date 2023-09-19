using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 400;
    public float sprintSpeed = 800;
    public float rotateSpeed;
    public Transform cameraLook;
    private bool sprint => Input.GetKey(KeyCode.LeftShift);

    void Update()
    {
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(horizontalAxis, 0.0f, verticalAxis);
        dir = Quaternion.AngleAxis(cameraLook.rotation.eulerAngles.y, Vector3.up) * dir;
        dir.Normalize();

        Cursor.visible = false;
        
        controller.SimpleMove(dir * (sprint ? sprintSpeed : speed) * Time.deltaTime);
        
        if (dir.magnitude >= 0.1f)
        {
            Quaternion rotate = Quaternion.LookRotation(dir, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotate, rotateSpeed * Time.deltaTime);
        }
    }
}
