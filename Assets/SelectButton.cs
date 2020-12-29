using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectButton : MonoBehaviour
{
    public void StartAr() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

    }
   
    
}
