using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackroundScript : MonoBehaviour
{

    private Material Baggrund;
    private float offset;
    public float BackroundSpeed;


    // Start is called before the first frame update
    void Start()
    {

        Baggrund = GetComponent<SpriteRenderer>().material;

        
        
    }

    // Update is called once per frame
    void Update()
    {

        offset += Time.deltaTime * BackroundSpeed;
        Baggrund.SetTextureOffset("_MainTex", new Vector2(offset,0));

    }
}
