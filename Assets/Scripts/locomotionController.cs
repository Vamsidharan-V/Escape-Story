using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class locomotionController : MonoBehaviour
{
    public XRController leftteleportray;
    public XRController rightteleportray;
    public InputHelpers.Button teleportactivationButton;
    public float activationThreshold = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (leftteleportray)
        {
            leftteleportray.gameObject.SetActive(checkActivated(leftteleportray));
        }
        if (rightteleportray)
        {
            rightteleportray.gameObject.SetActive(checkActivated(rightteleportray));
        }

    }
    public bool checkActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportactivationButton, out bool isActivated, activationThreshold);
        return isActivated;
    }
}
