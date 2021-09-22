using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
    private InputDevice targetdevice;
    GameObject spawnedController;
    public List<GameObject> controllers;
    public InputDeviceCharacteristics controllerChar;
    private GameObject spawnedHandobject;
    public GameObject handModel;
    public bool isControllerEnabled = false;
    private Animator handAnimator;
    // Start is called before the first frame update
    void Start()
    {
        Initialize();

    }
    private void Initialize()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerChar, devices);

        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }
        if (devices.Count > 0)
        {
            targetdevice = devices[0];
            GameObject currentController = controllers.Find(controller => controller.name == targetdevice.name);
            if (currentController)
            {
                spawnedController = Instantiate(currentController, transform);
            }
            else
            {
                spawnedController = Instantiate(controllers[0], transform);
            }
            spawnedHandobject = Instantiate(handModel, transform);
            handAnimator = spawnedHandobject.GetComponent<Animator>();
        }
    }
    private void UpdateHandAnimation()
    {
        if (targetdevice.TryGetFeatureValue(CommonUsages.trigger, out float trigval))
        {
            handAnimator.SetFloat("Trigger", trigval);
        }
        else
        {
            handAnimator.SetFloat("Trigger", 0);
        }
        if (targetdevice.TryGetFeatureValue(CommonUsages.grip, out float gripval))
        {
            handAnimator.SetFloat("Grip", gripval);
        }
        else
        {
            handAnimator.SetFloat("Grip", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!targetdevice.isValid)
        {
            Initialize();
        }
        else
        {
            if (isControllerEnabled)
            {
                spawnedHandobject.SetActive(false);
                spawnedController.SetActive(true);
            }
            else
            {
                spawnedHandobject.SetActive(true);
                spawnedController.SetActive(false);
                UpdateHandAnimation();
            }
        }

    }
}
