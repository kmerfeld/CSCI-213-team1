using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class death_script : MonoBehaviour
{
    public string DeathScreen;
    void OnCollisionEnter2D(Collider2D obj)
    {
        
        /*if (obj.gameObject.tag == "Player")
        {
            SceneManager.LoadScene (DeathScreen);
        }*/
        Destroy(obj.gameObject);
    }
}
