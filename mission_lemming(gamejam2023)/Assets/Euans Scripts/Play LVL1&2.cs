using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play1 : MonoBehaviour
{
      public void PlayLVL1()

    {
        SceneManager.LoadScene("Level 1");
    }



    public void PlayLVL2()

    {
        SceneManager.LoadScene("Level 2");
    }
}
