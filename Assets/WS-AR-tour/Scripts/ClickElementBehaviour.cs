using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickElementBehaviour : MonoBehaviour
{
    public GameObject labelPrefab;
    public Transform labelPosition;
    private GameObject currentLabel;

    private void OnMouseDown()
    {
        Debug.Log("Element clicked: " + gameObject.name);
        if (currentLabel != null)
        {
            Destroy(currentLabel);
        }
        if (labelPrefab != null)
        {
            currentLabel=Instantiate(labelPrefab);
            ItemLabelBehaviour labelBehaviour = currentLabel.GetComponent<ItemLabelBehaviour>();
            if (labelBehaviour != null && labelPosition != null)
            {
                labelBehaviour.UpdatePositionAndLabel(labelPosition, gameObject.name);
            }
        }
    }
}
