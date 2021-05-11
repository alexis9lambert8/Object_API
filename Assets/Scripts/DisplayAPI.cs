using cakeslice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DisplayAPI : MonoBehaviour
{
    [SerializeField]
    private Outline outline;
    [SerializeField]
    private DisplayObjectInformation menuItemPrefab;
    [SerializeField]
    private GameObject menuCanvas;

    private DisplayObjectInformation menuItemInstance;

    private void Awake()
    {
        menuItemInstance = Instantiate(menuItemPrefab, menuCanvas.transform);
        menuItemInstance.buttonClicked += () => ToggleOutline(false);
    }

    private void OnMouseDown()
    {
        ToggleOutline(outline.eraseRenderer);
    }

    private void ToggleOutline(bool active)
    {
        outline.eraseRenderer = !active;
        menuItemInstance.gameObject.SetActive(active);
    }


}
