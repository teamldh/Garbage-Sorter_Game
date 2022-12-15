using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int star;
    public int levelIndex;
    public Sprite starSprite;
    
    [Header("Panel Manager")]
    public GameObject panelGameOver;
    public GameObject panelTimesUp;
    public GameObject panelHealth;
    public GameObject panelTimer;
    public GameObject panelScore;
    public GameObject panelPause;
    public GameObject panelHelp;
    public GameObject skorTxt;
    public GameObject star_1, star_2, star_3;

    [Header("Timer Manager")]
    public Text countTimerTxt;
    public float durationTime;
    private float timer;
    private bool timerRun = false;
    public Image durationImage;
    private float skorAkhir;
    private float perhitunganSkor;

    // Start is called before the first frame update
    void Start()
    {
        //AdsManager.instance.requestInterstitalAds();
        instance = this;
        countTimerTxt.text = durationTime.ToString();
        timerRun = true;
        durationImage.fillAmount=0;
        timer=0;
        panelGameOver.SetActive(false);
        panelTimesUp.SetActive(false);
        panelTimesUp.SetActive(false);
        panelPause.SetActive(false);
        panelHelp.SetActive(false);
        panelScore.SetActive(true);
        panelTimer.SetActive(true);
        panelHealth.SetActive(true);
        star_1.SetActive(true);
        star_2.SetActive(true);
        star_3.SetActive(true);
        InterstitialAds.instance.LoadAd();
    }

    //Update is called once per frame
    void Update()
    {
        if (timerRun)
        {
            if(timer < durationTime){
                timer += Time.deltaTime;
                countTimerTxt.text = Mathf.Round(timer).ToString();
                durationImage.fillAmount = timer / durationTime;
            }
            else{
                //AdsManager.instance.showAds();
                Debug.Log("Waktu habis");
                timerRun = false;
                timer = durationTime;
                panelTimesUp.SetActive(true);
                panelScore.SetActive(false);
                panelTimer.SetActive(false);
                panelHealth.SetActive(false);
                Sound_Manager.instance.WinSFX();
                InterstitialAds.instance.ShowAd();
                Time.timeScale = 0;
                // if (PlayerPrefs.GetInt("highScore") < skor.GetComponent<score>().skor){
                //     PlayerPrefs.SetInt("highScore", skor.GetComponent<score>().skor);
                // }
                endScoreStar();
            }
        }
    }

    public void gameOver(){
        InterstitialAds.instance.ShowAd();
        panelGameOver.SetActive(true);
        panelScore.SetActive(false);
        panelTimer.SetActive(false);
        panelHealth.SetActive(false);
        Time.timeScale = 0;
    }

    public void helpBtn(){
        panelHelp.SetActive(true);
        panelPause.SetActive(false);
    }
    public void backToPause(){
        panelHelp.SetActive(false);
        panelPause.SetActive(true);
    }
    public void backBtnToPause(){
        panelPause.SetActive(true);
        panelHelp.SetActive(false);
    }

    public void pause(){
        panelPause.SetActive(true);
        Time.timeScale = 0;
    }

    //button
    public void resumeBtn(){
        panelPause.SetActive(false);
        Time.timeScale = 1;
    }

    //skor perlevelnya
    //perhitungan score (skorAkhor / 50) * 100
    private void endScoreStar(){
        skorAkhir = skorTxt.GetComponent<score>().skor;
        perhitunganSkor = (skorAkhir / 50) * 100;
        Debug.Log(perhitunganSkor);

        if (perhitunganSkor >= 71 || perhitunganSkor >=100){
            star_1.gameObject.GetComponent<Image>().sprite = starSprite;
            star_2.gameObject.GetComponent<Image>().sprite = starSprite;
            star_3.gameObject.GetComponent<Image>().sprite = starSprite;
            Debug.Log("bintang 3");
            star = 3;
            if(star > PlayerPrefs.GetInt("Lv" + levelIndex)){
                PlayerPrefs.SetInt("Lv" + levelIndex, star);
                PlayerPrefs.SetInt("Lv", levelIndex + 1);
            }
        }
        
        else if (perhitunganSkor >= 40 && perhitunganSkor <=70){
            star_1.gameObject.GetComponent<Image>().sprite = starSprite;
            star_2.gameObject.GetComponent<Image>().sprite = starSprite;
            // star_3.SetActive(true);
            Debug.Log("bintang 2");
            star = 2;
            if(star > PlayerPrefs.GetInt("Lv" + levelIndex)){
                PlayerPrefs.SetInt("Lv" + levelIndex, star);
                PlayerPrefs.SetInt("Lv", levelIndex + 1);
            }
        }
        
        else{
            star_1.gameObject.GetComponent<Image>().sprite = starSprite;
            // star_2.SetActive(true);
            // star_3.SetActive(true);
            Debug.Log("bintang 1");
            star = 1;
            if(star > PlayerPrefs.GetInt("Lv" + levelIndex)){
                PlayerPrefs.SetInt("Lv" + levelIndex, star);
                PlayerPrefs.SetInt("Lv", levelIndex + 1);
            }
        }
    }
}
