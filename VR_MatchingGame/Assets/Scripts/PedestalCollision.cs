using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PedestalCollision : MonoBehaviour
{
    public void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Testing");
        Debug.Log(collision.name);
        Debug.Log(this.gameObject.name);

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
