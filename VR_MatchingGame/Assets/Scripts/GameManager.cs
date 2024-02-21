using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PedestalCollision[] pedestals;   
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void CheckForWin()
    {
        foreach(var ped in pedestals)
        {
           if(!ped.rightCube)
            {
                return;
            }
        }
        Debug.Log("You win");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
