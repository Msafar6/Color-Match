using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ObjectsScript : MonoBehaviour
{
    
    public GameObject MovingBars1;
    public GameObject MovingBars2;

    public GameObject cam;
    public GameObject player;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //InvokeRepeating("ChangeBarPos",3,0);
        //if (MovingBars1.GetComponent<Transform>().position.x < -6.5f) 
        //{
        //    Debug.Log(" MovingBars1.GetComponent<Transform>().localPosition.x < -7.66f)");
        //    MovingBars1.GetComponent<Transform>().position = new Vector3(5.94f, -5.58f, 0);
                
        //}

        
        if (player.GetComponent<Transform>().position.y > cam.GetComponent<Transform>().position.y)
        {
            cam.GetComponent<Transform>().position = new Vector3(0, player.GetComponent<Transform>().position.y, -10);
        }
       
       
        
        
    }

    //void ChangeBarPos() 
    //{
       
    //    MovingBars1.GetComponent<Transform>().DOLocalMoveX(-7.66f, 1f).SetEase(Ease.Linear);
   
    //}
}
