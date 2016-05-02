using UnityEngine;
using System.Collections;

namespace UnityStandardAssets._2D
{
    public class KillBox : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
    {
            //these two lines can probably not be here, but i was getting 
            //null pointer without them
            GameObject player = GameObject.FindWithTag("Player");
            Transform playerTransform = player.transform;
            PlatformerCharacter2D platformchar = player.GetComponent<PlatformerCharacter2D>();

            //if its player
            if (other.gameObject.tag == "Player")
            {
                platformchar.AddHealth(-1);
            }
        }
}
}

