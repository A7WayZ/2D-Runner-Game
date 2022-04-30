using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Goal : MonoBehaviour
{
    public TimeManager TM;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            TM.StopAndSaveScore();

        }
    }

}
