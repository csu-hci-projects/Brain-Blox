 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class DragObject : MonoBehaviour
 {
     public float yOffsetForDraggedObject = 1;
 
     Plane plane;
     float distance;
     
     private void Start()
     {
        plane = new Plane(Vector3.up, new Vector3(0, gameObject.transform.position.y, 0));
     }
 
     void OnMouseDrag()
     {
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         if (plane.Raycast(ray, out distance))
         {
             transform.position = ray.GetPoint(distance);
         }
     }
 }

