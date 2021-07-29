using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryPlatform : MonoBehaviour
{
    [SerializeField]
    public Transform endPoint;
    
    //public GameObject ParentLevelObject;
    public float platform_LengthX = -1;

    public int platform_EndPositionX = -1;
    public int platform_EndPositionY = -1;

    public Transform parentTransform;

    

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    public void SetPlatformScale(float length)
    {
        if (length > 1f)
        {
            platform_LengthX = length;
            Vector3 customScale = transform.localScale;
            customScale.x = platform_LengthX;
            transform.localScale = customScale;

            transform.position += new Vector3((float)System.Math.Round(transform.localScale.x/2, 2), 0, 0);
            CalculateEndPosition();
        }
    }
    
    public void CalculateEndPosition()
    {
        if(transform.childCount == 0)
        {
            //Create EndPosition Object
            var point = Instantiate(endPoint, transform.position + new Vector3((float)System.Math.Round(transform.localScale.x / 2, 2), 0f, 0f), Quaternion.identity);
            point.transform.SetParent(transform);
        }
        
    }

}
