using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float distanceAway;
    [SerializeField]
    private float distanceUp;
    [SerializeField]
    private Transform followXform;

    public string tagObj; 


    //Smoothing and damping
    private Vector3 velocityCamSmooth = Vector3.zero;
    [SerializeField]
    private float camSmoothDampTime=0.1f;

    //private global only
    private Vector3 lookDir;
    private Vector3 targetPosition;    

    // Start is called before the first frame update
    void Start()
    {
        followXform = GameObject.FindGameObjectWithTag(tagObj).transform;
        lookDir= followXform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate() 
    {
        Vector3 characterOffset= followXform.position + new Vector3(0f, distanceUp, 0f);

        lookDir = characterOffset - this.transform.position;
        lookDir.y =0;
        lookDir.Normalize();


        targetPosition = characterOffset +followXform.up * distanceUp - lookDir*distanceAway;
        
        CompensateForWallas(characterOffset, ref targetPosition);
        smoothPosition(this.transform.position, targetPosition);
        transform.LookAt(characterOffset);
    }

    private void smoothPosition(Vector3 fromPos, Vector3 toPos)
    {
        this.transform.position = Vector3.SmoothDamp(fromPos, toPos, ref velocityCamSmooth, camSmoothDampTime);
    }

    private void CompensateForWallas(Vector3 fromObject, ref Vector3 toTarget)
    {
        RaycastHit wallHit= new RaycastHit();
        if(Physics.Linecast(fromObject, toTarget, out wallHit))
        {
            toTarget= new Vector3 (wallHit.point.x, toTarget.y, wallHit.point.z);
        }
    }

}
