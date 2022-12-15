using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manager : MonoBehaviour
{
    public static Sound_Manager instance { get; set;}
    public AudioSource BGM;
    public AudioSource SFX;
    public AudioClip SFXbtn;
    public AudioClip SFXwin;
    private void Awake() {
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(this);
        }
        else {
            Destroy(gameObject);
        }
    }

    public void ButtonSFX(){
        SFX.PlayOneShot(SFXbtn);
    }
    
    public void WinSFX(){
        SFX.PlayOneShot(SFXwin);
    }

    public void MuteBGM(){
        if (BGM.mute == false){
            BGM.mute = true;
        }
        else {
            BGM.mute = false;
        }
    }

    public void MuteSFX(){
        if (SFX.mute == false){
            SFX.mute = true;
        }
        else {
            SFX.mute = false;
        }
    }
}
