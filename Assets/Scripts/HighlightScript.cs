using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightScript : MonoBehaviour
{
    
    public string objectName;

    private new Renderer renderer;
    private Color startColour;

    private bool _displayObjectName = false;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void OnGUI()
    {       
        DisplayName();
    }

    private void OnMouseEnter()
    {
        startColour = renderer.material.color;
        renderer.material.color = Color.yellow;
        _displayObjectName = true;
    }

    private void OnMouseExit()
    {
        renderer.material.color = startColour;
        _displayObjectName = false;
    }

    public void DisplayName()
    {
        if (_displayObjectName == true)
        {
            GUI.Box(new Rect(Event.current.mousePosition.x - 150, Event.current.mousePosition.y, 150, 25), objectName);
        }
    }
}
