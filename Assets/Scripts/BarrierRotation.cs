using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierRotation : MonoBehaviour
{
    public List<GameObject> obj;
    private Camera cam;
    public float SpeedOfRotation;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        for (int i = 0; i < obj.Count; i++)
         {
             obj[i].GetComponent<Transform>().Rotate(new Vector3(0, 0, SpeedOfRotation));

         }
        
    }
}
