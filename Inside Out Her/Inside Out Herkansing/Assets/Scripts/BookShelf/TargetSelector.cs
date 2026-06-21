using UnityEngine;

public class TargetSelector : MonoBehaviour
{
    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
        }

    }
    //public Camera camera;
    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

    //        if (Physics.Raycast(ray, out RaycastHit hitInfo))
    //        {
    //            //    if (hitInfo.collider.gameObject.GetComponent<Target>() != null)
    //            //    {
    //            //        Vector3 distanceToTarget = hitInfo.point - transform.position;
    //            //        Vector3 forceDirection
    //            //    }
    //            //}
    //        }
    //    }
    //}
}
