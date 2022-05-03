using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackroundScript : MonoBehaviour
{


    public RawImage backround;
    public float ScrollSpeed;


    // Update is called once per frame
    void Update()
    {

        backround.uvRect = new Rect(backround.uvRect.position + new Vector2(ScrollSpeed, 0)*Time.deltaTime, backround.uvRect.size);
        

    }
}
