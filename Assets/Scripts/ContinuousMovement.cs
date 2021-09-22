using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ContinuousMovement: MonoBehaviour
{ 
    public float speed = 1;
    public XRNode inputSource;
    private Vector2 inputAxis;
    private CharacterController character;
    public layerMask groundLayer;
    public float addtionalHeight = 0.2f;

    private float falling speed;
    private XRRig rig;
    private Vector2inputAxis;
    private CharacterController charecter;

    void Start()
    {
        character = GetComponent<CharacterController>();
        rig = GetComponent<XRRig>(); 
    }


    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
    }

    private void FixedUpdate()

    {
        CapsuleFollowHeadset();
        Quaterion headYaw = Quaterion.Euler(0, rig.cameraGameObject.transform.eulerAngles.y, 0);
        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);


        Vector3 direction = new Vector3(inputAxis.x, 0, inputAxis.y);

        character.Move(direction * Time.fixedDeltaTime * speed);
        bool isGround = CheckIfGrouded();
        if (isGrounded)
            fallingSpeed = 0;
        else
            falling += gravity * Time.fixedDeltaTime;
        character.Move(Vector3.up * fallingSpeed * Time.fixedDeltaTime);
    }
     void CapsuleFollowHeadset()
     {
        character.height = rig.cameraInRigSpaceHeight + addtionalHeight;
        Vector3 capsuleCenter transform.InverseTransformPoint(rig.cameraGameObject.transform.position);
        character.center = new Vector3(capsuleCenter.x, character.height / 2 + character.skinWidth, capsuleCapsule.z);
     }
    bool CheckIfGrounded()

59

{

60

61

//tells us if on ground

Vector3 rayStart transform.TransformPoint(character.center);

62

63

64

float rayLength character.center.y + 0.01f;

return hasHit;

, capsuleCenter.

bool hasHit Physics.SphereCast(rayStart, character.radius, Vector3.down, out RaycastHit hitInfo, rayLeng

return hasHit;`

}
