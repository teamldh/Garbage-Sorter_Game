using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingBGM_SFX : MonoBehaviour
{
    public Sprite Bgm_On;
    public Sprite Bgm_Off;
    public Sprite SFX_On;
    public Sprite SFX_Off;
    public Button BGM_Mute;
    public Button SFX_Mute;
    // public Slider BGMSlider;
    // public Slider SFXSlider;
    // Start is called before the first frame update
    void Start()
    {
        if(Sound_Manager.instance.BGM.mute ==  true){
            BGM_Mute.image.sprite = Bgm_Off;
        }
        else{
            BGM_Mute.image.sprite = Bgm_On;
        }

        if(Sound_Manager.instance.SFX.mute ==  true){
            SFX_Mute.image.sprite = SFX_Off;
        }
        else{
            SFX_Mute.image.sprite = SFX_On;
        }
        
        // BGMSlider.value = Sound_Manager.instance.BGM.volume;
        // SFXSlider.value = Sound_Manager.instance.SFX.volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // public void sliderVolumeBGM(){
    //     Sound_Manager.instance.BGM.volume = BGMSlider.value;
    // }

    // public void sliderVolumeSFX(){
    //     Sound_Manager.instance.SFX.volume = SFXSlider.value;
    // }

    public void buttonSFX(){
        Sound_Manager.instance.ButtonSFX();
    }
    public void winSFX(){
        Sound_Manager.instance.WinSFX();
    }

    public void BGMMute(){
        Sound_Manager.instance.MuteBGM();

        if(Sound_Manager.instance.BGM.mute ==  true){
            BGM_Mute.gameObject.GetComponent<Image>().sprite = Bgm_Off;
        }
        else{
            BGM_Mute.gameObject.GetComponent<Image>().sprite = Bgm_On;
        }
    }
    public void SFXMute(){
        Sound_Manager.instance.MuteSFX();

        if(Sound_Manager.instance.SFX.mute ==  true){
            SFX_Mute.gameObject.GetComponent<Image>().sprite = SFX_Off;
        }
        else{
            SFX_Mute.gameObject.GetComponent<Image>().sprite = SFX_On;
        }
    }
}
