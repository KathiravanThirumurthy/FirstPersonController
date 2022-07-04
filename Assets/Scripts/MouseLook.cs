using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    private float senX=100f;
    private float senY = 50f;
    [SerializeField]
    private Transform _playerOrinetaion;
    private float _xRotation=0;
    private float _yRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // getting xmouse
        float mouseX = Input.GetAxis("Mouse X") * senX * Time.deltaTime;
       //getting ymouse
        float mouseY = Input.GetAxis("Mouse Y") * senY  * Time.deltaTime;
        // add xInput to ur y rotation
        _yRotation += mouseX;
        // and subtrcat yInput to ur x rotation
        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation,-90f,90f);
        transform.rotation = Quaternion.Euler(_xRotation,_yRotation,0);
        _playerOrinetaion.rotation = Quaternion.Euler(0,_yRotation,0);
       

    }
}
