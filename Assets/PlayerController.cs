using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private InputActionReference jumpActionReference;
    [SerializeField] private InputActionReference originPosActionReference;
    [SerializeField] private float jumpForce = 300.0f;
    
    private Rigidbody rigidBody;
    private XROrigin xRRig;
    private CapsuleCollider collider;
    private bool isGrounded => Physics.Raycast(new Vector2(transform.position.x, transform.position.y), Vector3.down, 2.0f);
    private Vector3 originPosition;

    void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);
    }
        void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        xRRig = GetComponent<XROrigin>();
        collider = GetComponent<CapsuleCollider>();
        jumpActionReference.action.performed += OnJump;
        originPosActionReference.action.performed += OnReturnToOriginPos;
        originPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 center = xRRig.CameraInOriginSpacePos;
        collider.center = new Vector3(center.x, collider.center.y, center.z);
        collider.height = xRRig.CameraInOriginSpaceHeight;
    }

    void OnJump(InputAction.CallbackContext obj)
    {
        if (isGrounded) return;
        rigidBody.AddForce(Vector3.up * jumpForce);
    }

    void OnReturnToOriginPos(InputAction.CallbackContext obj)
    {
        transform.position = originPosition;
    }
}
