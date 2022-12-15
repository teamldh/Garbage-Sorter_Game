using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject PanelMainMenu;
    public GameObject PanelPengaturan;
    public GameObject PanelCaraBermain;
    public GameObject PanelTentang;
    public GameObject cara1, cara2, cara3, cara4, cara5;
    public GameObject PopUpAlert;
    public GameObject DataTerhapus;
    public GameObject BtnKembali1, BtnKembali2, xBtn;
    public GameObject BtnLanjut;
    public GameObject imgBibi, imgBocil;
    private void Start() {
        PanelMainMenu.SetActive(true);
        imgBibi.SetActive(true);
        imgBocil.SetActive(true);
        PanelPengaturan.SetActive(false);
        PanelCaraBermain.SetActive(false);
        PanelTentang.SetActive(false);
        PopUpAlert.SetActive(false);
        DataTerhapus.SetActive(false);
        BtnKembali1.SetActive(false);
    }
    public void MulaiGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Pengaturan(){
        PanelMainMenu.SetActive(false);
        PanelPengaturan.SetActive(true);
        imgBibi.SetActive(false);
        imgBocil.SetActive(false);
        PanelCaraBermain.SetActive(false);
        PanelTentang.SetActive(false);
        PopUpAlert.SetActive(false);
        DataTerhapus.SetActive(false);
        BtnKembali1.SetActive(true);
    }
    public void CaraBermain(){
        PanelMainMenu.SetActive(false);
        PanelPengaturan.SetActive(false);
        PanelCaraBermain.SetActive(true);
        imgBibi.SetActive(false);
        imgBocil.SetActive(false);
        PanelTentang.SetActive(false);
        PopUpAlert.SetActive(false);
        DataTerhapus.SetActive(false);
        BtnKembali1.SetActive(false);
        BtnKembali2.SetActive(true);
        BtnLanjut.SetActive(true);
        xBtn.SetActive(true);
    }
    public void Tentang(){
        PanelMainMenu.SetActive(false);
        PanelPengaturan.SetActive(false);
        PanelCaraBermain.SetActive(false);
        PanelTentang.SetActive(true);
        imgBibi.SetActive(false);
        imgBocil.SetActive(false);
        PopUpAlert.SetActive(false);
        DataTerhapus.SetActive(false);
        BtnKembali1.SetActive(false);
    }
    public void kembaliCaraBermain(){
        if(cara5.activeInHierarchy == true){
            cara1.SetActive(false);
            cara2.SetActive(false);
            cara3.SetActive(false);
            cara4.SetActive(true);
            cara5.SetActive(false);
        }
        else if(cara4.activeInHierarchy == true){
            cara1.SetActive(false);
            cara2.SetActive(false);
            cara3.SetActive(true);
            cara4.SetActive(false);
        }
        else if(cara3.activeInHierarchy == true){
            cara1.SetActive(false);
            cara2.SetActive(true);
            cara3.SetActive(false);
        }
        else if(cara2.activeInHierarchy == true){
            cara1.SetActive(true);
            cara2.SetActive(false);
        }
        else{
            Start();
        }
    }
    public void lanjutCara(){
        if(cara1.activeInHierarchy == true){
            cara1.SetActive(false);
            cara2.SetActive(true);
        }
        else if(cara2.activeInHierarchy == true){
            cara1.SetActive(false);
            cara2.SetActive(false);
            cara3.SetActive(true);
        }
        else if(cara3.activeInHierarchy == true){
            cara1.SetActive(false);
            cara2.SetActive(false);
            cara3.SetActive(false);
            cara4.SetActive(true);
        }
        else{
            cara1.SetActive(false);
            cara2.SetActive(false);
            cara3.SetActive(false);
            cara4.SetActive(false);
            cara5.SetActive(true);
        }
    }
    public void KembaliBtnX(){
        Start();
    }
    public void PopUp(){
        PanelMainMenu.SetActive(false);
        PanelPengaturan.SetActive(false);
        PanelCaraBermain.SetActive(false);
        PanelTentang.SetActive(false);
        PopUpAlert.SetActive(true);
        DataTerhapus.SetActive(false);
        BtnKembali1.SetActive(false);
    }
    public void HapusData(){
        PlayerPrefs.DeleteAll();
        DataTerhapus.SetActive(true);
        StartCoroutine(deleteData());
    }
    IEnumerator deleteData(){
        yield return new WaitForSeconds(3);
        Start();
    }
    public void KeluarGame()
    {
        Application.Quit();
        Debug.Log("Keluar");
    }
}
