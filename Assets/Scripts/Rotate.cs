using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    public Text BestScore;

    private void Start()
    {
        
        BestScore.text = PlayerPrefs.GetInt("Score").ToString();
    }

    void Update()
    {
        this.gameObject.GetComponent<Transform>().Rotate(new Vector3(0,0,1));
    }

    public void LoadGamePlay() 
    {
        FindObjectOfType<soundmanager>().PlaySoundManager("btn");
        SceneManager.LoadScene("Gameplay");
    }
}
