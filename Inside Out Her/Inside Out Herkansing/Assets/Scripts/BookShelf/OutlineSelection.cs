using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OutlineSelection : MonoBehaviour
{
    private Transform highlight;
    private Transform selection;
    private RaycastHit raycastHit;

    public List<GameObject> buttons = new List<GameObject>();   

    void Update()
    {
        // Highlight
        if (highlight != null)
        {
            highlight.gameObject.GetComponent<Outline>().enabled = false;
            highlight = null;
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!EventSystem.current.IsPointerOverGameObject() && Physics.Raycast(ray, out raycastHit)) //Make sure you have EventSystem in the hierarchy before using EventSystem
        {
            highlight = raycastHit.transform;
            if (highlight.CompareTag("Selectable") && highlight != selection)
            {
                if (highlight.gameObject.GetComponent<Outline>() != null)
                {
                    highlight.gameObject.GetComponent<Outline>().enabled = true;
                }
                else
                {
                    Outline outline = highlight.gameObject.AddComponent<Outline>();
                    outline.enabled = true;
                    highlight.gameObject.GetComponent<Outline>().OutlineColor = Color.magenta;
                    highlight.gameObject.GetComponent<Outline>().OutlineWidth = 7.0f;
                }
            }
            else
            {
                highlight = null;
            }
        }

        // Selection
        if (Input.GetMouseButtonDown(0))
        {
            if (highlight)
            {
                if (selection != null)
                {
                    selection.gameObject.GetComponent<Outline>().enabled = false;
                }
                selection = raycastHit.transform;
                selection.gameObject.GetComponent<Outline>().enabled = true;

                for (int i = buttons.Count - 1; i < 0; i--)
                {
                    buttons[i].SetActive(false);
                }

                var script = selection.gameObject.GetComponent<Objects>();
                script.button.SetActive(true);
                highlight = null;
                Debug.Log(script.button);
                Debug.Log("Highlight turned on");
            }
            else
            {
                //var script = selection.gameObject.GetComponent<Objects>();
                //Debug.Log(script);
                //script.button.SetActive(false);

                //Debug.Log("Highlight turned off");
                if (selection)
                {
                    
                    selection.gameObject.GetComponent<Outline>().enabled = false;
                    selection = null;

                    
                }
                
            }
        }
    }

}
