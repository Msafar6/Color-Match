using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishScreenManager : MonoBehaviour
{

    public void MainManu() 
    {
       
        FindObjectOfType<soundmanager>().PlaySoundManager("btn");
        SceneManager.LoadScene("MainScreen");
    }

    public void PlayAgain()
    {
        FindObjectOfType<soundmanager>().PlaySoundManager("btn");
        SceneManager.LoadScene("Gameplay");
    }

}
