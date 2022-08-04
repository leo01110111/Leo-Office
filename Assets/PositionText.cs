using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PositionText : MonoBehaviour
{
    public TextMeshProUGUI PosText;
 

    //UnityEngine.XR.InputDevice device;
    //public Quaternion HeadsetVector;
    // public Transform GameObject;
    // public int X, Y, Z;
    //public static Quaternion GetLocalRotation(XR.XRNode node);

   
    void Start()
    {

        //SetText();

        /*var CenterEyeDevices = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevicesAtXRNode(UnityEngine.XR.XRNode.CenterEye, CenterEyeDevices);

        if (CenterEyeDevices.Count == 1)
        {
            UnityEngine.XR.InputDevice device = CenterEyeDevices[0];
            Debug.Log(string.Format("Device name '{0}' with role '{1}'", device.name, device.role.ToString()));
        }
        else if (CenterEyeDevices.Count > 1)
        {
            Debug.Log("Found more than one center of eye!");
        }*/

    }

    void Update()
    {
        //private Transform RotationX = transform;
        PosText.text = "Position: " + transform.position.ToString() + "\n Rotation: " + transform.rotation.eulerAngles.ToString();
        /*Quaternion triggerValue;
        if (device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.CenterEye, out triggerValue) && triggerValue)
        {
            Debug.Log("Trigger button is pressed.");
        }
        if (GameObject.eulerAngles.x <= 180f)
        {
            RotationX = GameObject.eulerAngles.x;
        }
        else
        {
            RotationX = GameObject.eulerAngles.x - 360f;
        }*/
    }

   /* void SetText()
    {
        // PosText.text =  HeadsetVector.eulerAngles.x.ToString();
        //PosText.text = RotationX.ToString();
    }*/
}
