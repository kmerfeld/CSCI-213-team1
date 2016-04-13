using UnityEngine;
using System.Collections;

public class Minigame_collider : MonoBehaviour {
    
    void OnCollisionEnter(Collision col)
    {
        //if (col.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
