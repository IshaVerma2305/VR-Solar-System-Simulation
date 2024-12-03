using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeSystem : MonoBehaviour
{
public GameObject reticle;
public Color inactiveReticleColor = Color.gray;
public Color activeReticleColor = Color.green;
private GazeableObject currentGazeObject;
private GazeableObject currentSelectedObject;
private RaycastHit lastHit;
    
    // Start is called before the first frame update
    void Start()
    {
        SetReticleColor(inactiveReticleColor);
    }

    // Update is called once per frame
    void Update()
    {
        ProcessGaze();
        CheckforInput(lastHit);
    }
    private void SetReticleColor(Color reticleColor)
    {
    reticle.GetComponent<Renderer>().material.SetColor("_Color" ,reticleColor);
// Set the color of the reticle
    }


private void ClearCurrentObject()
{
   if(currentGazeObject != null)
   {
   currentGazeObject.OnGazeExit();
   SetReticleColor(inactiveReticleColor);
   currentGazeObject = null;// DO SOMETHING
   }
}

public void ProcessGaze()
{
Ray raycastRay = new Ray(transform.position, transform.forward);
RaycastHit hitInfo;
if (Physics.Raycast(raycastRay, out hitInfo))
{
    GameObject hitObj = hitInfo.collider.gameObject;
    GazeableObject gazeObj = hitObj.GetComponent<GazeableObject> ();
    if (gazeObj != null)
{
 // Object we're looking at is different
 if (gazeObj != currentGazeObject)
 {
 ClearCurrentObject();
 currentGazeObject = gazeObj;
 currentGazeObject.OnGazeEnter(hitInfo);
 SetReticleColor(activeReticleColor);
 }
 else
 {
 currentGazeObject.OnGaze(hitInfo);
 }
}
else
{
 ClearCurrentObject();
}
lastHit = hitInfo;
 // Do something to the object
 // Check if the object is interactable
// Check if the object is a new object
//(first time looking)
// Set the reticle color
}
else
{
    ClearCurrentObject();
}
Debug.DrawRay(raycastRay.origin, raycastRay.direction * 100);

}
private void CheckforInput(RaycastHit hitinfo)
{
if (Input.GetMouseButtonDown(0) && currentGazeObject != null)
{
 currentSelectedObject = currentGazeObject;
 currentSelectedObject.OnPress(hitinfo);
}
else if (Input.GetMouseButton(0) && currentSelectedObject != null)
{
 currentSelectedObject.OnHold(hitinfo);
}
else if (Input.GetMouseButtonUp(0) && currentSelectedObject != null)
{
 currentSelectedObject.OnRelease(hitinfo);
 currentSelectedObject = null;
}
// Check for down
// Check for hold
// Check for release
}

}
