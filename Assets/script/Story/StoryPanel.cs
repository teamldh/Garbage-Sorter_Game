using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryPanel : MonoBehaviour
{
    public GameObject[] PanelStory; 
    public Button lanjut, mulai;
    // Start is called before the first frame update
    void Start()
    {
        //canvas story
        PanelStory[0].SetActive(true);
        lanjut.gameObject.SetActive(true);
        mulai.gameObject.SetActive(false);
    }

    public void story1(){
        if(PanelStory[0].activeInHierarchy == true){
            PanelStory[0].SetActive(false);
            PanelStory[1].SetActive(true);
        }
        else if(PanelStory[1].activeInHierarchy == true){
            PanelStory[0].SetActive(false);
            PanelStory[1].SetActive(false);
            PanelStory[2].SetActive(true);
        }
        else {
            PanelStory[0].SetActive(false);
            PanelStory[1].SetActive(false);
            PanelStory[2].SetActive(false);
            PanelStory[3].SetActive(true);
            lanjut.gameObject.SetActive(false);
            mulai.gameObject.SetActive(true);
        }
    }
    public void story3(){
        if(PanelStory[0].activeInHierarchy == true){
            PanelStory[0].SetActive(false);
            PanelStory[1].SetActive(true);
        }
        else if(PanelStory[1].activeInHierarchy == true){
            PanelStory[0].SetActive(false);
            PanelStory[1].SetActive(false);
            PanelStory[2].SetActive(true);
        }
        else if(PanelStory[2].activeInHierarchy == true){
            PanelStory[0].SetActive(false);
            PanelStory[1].SetActive(false);
            PanelStory[2].SetActive(false);
            PanelStory[3].SetActive(true);
        }
        else {
            PanelStory[0].SetActive(false);
            PanelStory[1].SetActive(false);
            PanelStory[2].SetActive(false);
            PanelStory[3].SetActive(false);
            PanelStory[4].SetActive(true);
            lanjut.gameObject.SetActive(false);
            mulai.gameObject.SetActive(true);
        }
    }
    public void loadscene(string namescene){
        SceneManager.LoadScene(namescene);
    }
    public void btnSfx(){
        Sound_Manager.instance.ButtonSFX();
    }
}
