using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        //private void OnTriggerEnter2D(Collider2D other)
		//private void Start()
        //{
            //if (other.tag == "Player")
           
				
          
        //}
		void OnCollisionEnter2D(Collision2D coll)
		{
			SceneManager.LoadScene ("minigame");

		}
    }
}
