using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    public Rigidbody2D PlayerRig;
    public float JumpSpeed;
    public Text ScoreText;
    public GameObject BloomParticle;
    public GameObject FinishParticle;

    public Color32 red;
    public Color32 yellow;
    public Color32 megenta;
    public Color32 cyan;

    public string CurrentColor;
    int random;

    public static int Score;
    
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "00";
       // Score= PlayerPrefs.GetInt("Score");
        switch (Random.Range(0,3))
        {
            case 0:
                this.gameObject.GetComponent<SpriteRenderer>().color = red;
                CurrentColor = "red";
               
                break;

            case 1:
                this.gameObject.GetComponent<SpriteRenderer>().color = yellow;
                CurrentColor = "yellow";
             
                break;
            case 2:
                this.gameObject.GetComponent<SpriteRenderer>().color = megenta;
                CurrentColor = "megenta";
                
                break;
            case 3:
                this.gameObject.GetComponent<SpriteRenderer>().color = cyan;
                CurrentColor = "cyan";
               
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButton("Fire1"))
        //{
        //    Time.timeScale = 1;

        //}

    }
    private void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            PlayerRig.velocity = new Vector2(0, JumpSpeed * Time.fixedDeltaTime) ;
        }
    }

   


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ColorChanger")
        {
            
        FindObjectOfType<soundmanager>().PlaySoundManager("point");
            Score++;
            ScoreText.text = Score.ToString();
            if (Score > PlayerPrefs.GetInt("Score"))
            { PlayerPrefs.SetInt("Score", Score); }
            Debug.Log("Color Should be changed");
            random = Random.Range(0, 3);

            switch (random)
            {
                case 0:
                    this.gameObject.GetComponent<SpriteRenderer>().color = red;
                    CurrentColor = "red";
                    Instantiate(BloomParticle,this.gameObject.GetComponent<Transform>().position,Quaternion.identity);
                    Destroy(collision.gameObject);
                    break;

                case 1:
                    this.gameObject.GetComponent<SpriteRenderer>().color = yellow;
                    CurrentColor = "yellow";
                    Instantiate(BloomParticle, this.gameObject.GetComponent<Transform>().position, Quaternion.identity);

                    Destroy(collision.gameObject);
                    break;
                case 2:
                    this.gameObject.GetComponent<SpriteRenderer>().color = megenta;
                    CurrentColor = "megenta";
                    Instantiate(BloomParticle, this.gameObject.GetComponent<Transform>().position, Quaternion.identity);

                    Destroy(collision.gameObject);
                    break;
                case 3:
                    this.gameObject.GetComponent<SpriteRenderer>().color = cyan;
                    CurrentColor = "cyan";
                    Instantiate(BloomParticle, this.gameObject.GetComponent<Transform>().position, Quaternion.identity);

                    Destroy(collision.gameObject);
                    break;
            }

        }

        if (collision.tag != CurrentColor && collision.tag != "ColorChanger")
        {
            Score = 0;
            FindObjectOfType<soundmanager>().PlaySoundManager("Gameover");
            SceneManager.LoadScene("FinishScreen");
        }

        if (collision.tag == "finish" )
        {
            Instantiate(FinishParticle, this.gameObject.GetComponent<Transform>().position, Quaternion.identity);
            //FindObjectOfType<soundmanager>().PlaySoundManager("Gameover");
            StartCoroutine(GameOver());
        }

        }

    IEnumerator GameOver() 
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MainScreen");
    }
}
