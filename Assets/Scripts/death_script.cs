using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class death_script : MonoBehaviour
{
    public string DeathScreen;
    void OnCollisionEnter2D(Collision2D obj)
    {
        Destroy(obj.gameObject);
        if (obj.gameObject.tag == "Player")
        {
            SceneManager.LoadScene (DeathScreen);
        }
        
    }
}
