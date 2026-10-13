using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemLabelBehaviour : MonoBehaviour {

    public Text Label;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //TODO always turn the label to the Camera
        if (Camera.main != null)
        {
            transform.LookAt(Camera.main.transform);
            transform.Rotate(0, 180, 0); // Rotate 180 degrees to face the camera
        }
    }

    public void UpdatePositionAndLabel(Transform labelPositionTransform, string label = "")
    {
        //TODO update position of the label and label value
        if (Label != null) { 
            Label.text = label;
        }
        if (labelPositionTransform != null)
        {
            transform.SetParent(labelPositionTransform);
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
        }

    }
}
