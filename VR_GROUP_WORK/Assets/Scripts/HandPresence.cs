using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR; 


public class HandPresence : MonoBehaviour
{
    public bool showController = false;
    public InputDeviceCharacteristics controllerCharacteristics;
    public List<GameObject> controllerPrefabs;
    public GameObject handModelPrefab;
    public GameObject rightHandRayCaster;

    private InputDevice targetDevice;
    private GameObject spawnedController;
    private GameObject spawnedHandModel;

    private Animator handAnimaor;


    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        if (devices.Count > 0) {

            targetDevice = devices[0];
            GameObject prefab = controllerPrefabs.Find(controller => controller.name == targetDevice.name);
            if (prefab)
            {

                spawnedController = Instantiate(prefab, transform);
            }
            else {

                Debug.Log("Your controller doesnt exist in the system because it's shit m8");
                spawnedHandModel = Instantiate(controllerPrefabs[0], transform);
            }

            spawnedHandModel = Instantiate(handModelPrefab, transform);
            handAnimaor = spawnedHandModel.GetComponent<Animator>();
        }

    }

    void UpdateHandAnimation() {

        if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue)){

            handAnimaor.SetFloat("Trigger", triggerValue);
        }

        else {

            handAnimaor.SetFloat("Trigger", 0);
        }

        if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float gripValue)){

            handAnimaor.SetFloat("Grip", gripValue);
        }

        else
        {

            handAnimaor.SetFloat("Grip", 0);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (showController)
        {

            spawnedHandModel.SetActive(false);
            spawnedController.SetActive(true);
        }
        else if (spawnedHandModel)
        {

            spawnedHandModel.SetActive(true);
            spawnedController.SetActive(false);
            UpdateHandAnimation();
        }
        else
        {

            Destroy(rightHandRayCaster);
        }


    }
}
