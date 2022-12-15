using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Health : MonoBehaviour
{
    [Header("Perjenis sampah")]
    private int scoreSampah = 0;
    public Text JumlahSampahTxt;
    
    [Header("Score")]
    //private int score = 0;
    public Text scoreTxt;
    public string tagObject;
    public GameObject skor;

    // Start is called before the first frame update
    void Start()
    {
        
        JumlahSampahTxt.text = " " + scoreSampah;
        //scoreTxt.text = " " + score;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == tagObject){
            scoreSampah++;
            skor.GetComponent<score>().skor++;
            Health.health += 5f;
            JumlahSampahTxt.text = " " + scoreSampah;
            // score += 100;
            // scoreTxt.text = " " + score;
            Destroy(other.gameObject);
        }
        else if(other.tag != tagObject && other.tag != "Sampah"){
            Health.health -= 5f;
            if (Health.health <= 0){
                GameManager.instance.gameOver();
            }
            Destroy(other.gameObject);
        }
    }
}
