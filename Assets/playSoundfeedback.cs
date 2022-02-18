using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playSoundfeedback : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip TTS_Termosifone_Altri;
    public AudioClip TTS_Termosifone_Off;
    public AudioClip TTS_PC_Altri;
    public AudioClip TTS_PC_Treno;
    public AudioClip TTS_Bottiglia_Butto;
    public AudioClip TTS_Bottiglia_Riutilizzo;
    public AudioClip TTS_Caffe_Macchinetta;
    public AudioClip TTS_Caffe_Moka;
    public AudioClip TTS_Dispensa_Biscotti;
    public AudioClip TTS_Dispensa_Pane;
    public AudioClip TTS_Doccia_5;
    public AudioClip TTS_Doccia_1015;
    public AudioClip TTS_Doccia_20;
    public AudioClip TTS_Frigo_Bacon;
    public AudioClip TTS_Frigo_Mela_Marmellata;
    public AudioClip TTS_Frigo_Uova;
    public AudioClip TTS_Lavatrice_30;
    public AudioClip TTS_Lavatrice_Altri;
    public AudioClip TTS_Lavoro_Auto;
    public AudioClip TTS_Lavoro_Bici;
    public AudioClip TTS_Lavoro_Mezzi_Amici;
    public AudioClip TTS_Luci_Accese;
    public AudioClip TTS_Luci_Spengo;
    public AudioClip TTS_Roomba_Acceso;
    public AudioClip TTS_Roomba_Spento;



    

    // Start is called before the first frame update
    void Start()
    {
       audioSource = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void termosifone_altri() {
        audioSource.PlayOneShot(TTS_Termosifone_Altri);
    }
    public void termosifone_off() {
        audioSource.PlayOneShot(TTS_Termosifone_Off);
    }
    public void pc_altri() {
        audioSource.PlayOneShot(TTS_PC_Altri);
    }
    public void pc_treno() {
        audioSource.PlayOneShot(TTS_PC_Treno);
    }
    public void bottiglia_butto() {
        audioSource.PlayOneShot(TTS_Bottiglia_Butto);
    }
    public void bottiglia_riutilizzo() {
        audioSource.PlayOneShot(TTS_Bottiglia_Riutilizzo);
    }
    public void caffe_macchinetta() {
        audioSource.PlayOneShot(TTS_Caffe_Macchinetta);
    }
    public void caffe_moka() {
        audioSource.PlayOneShot(TTS_Caffe_Moka);
    }
    public void dispensa_biscotti() {
        audioSource.PlayOneShot(TTS_Dispensa_Biscotti);
    }
    public void dispensa_pane() {
        audioSource.PlayOneShot(TTS_Dispensa_Pane);
    }
    public void doccia_5() {
        audioSource.PlayOneShot(TTS_Doccia_5);
    }
    public void doccia_1015() {
        audioSource.PlayOneShot(TTS_Doccia_1015);
    }
    public void doccia_20() {
        audioSource.PlayOneShot(TTS_Doccia_20);
    }
    public void frigo_bacon() {
        audioSource.PlayOneShot(TTS_Frigo_Bacon);
    }
    public void frigo_mela_marmellata() {
        audioSource.PlayOneShot(TTS_Frigo_Mela_Marmellata);
    }
    public void frigo_uova() {
        audioSource.PlayOneShot(TTS_Frigo_Uova);
    }
    public void lavatrice_30() {
        audioSource.PlayOneShot(TTS_Lavatrice_30);
    }
    public void lavatrice_altri() {
        audioSource.PlayOneShot(TTS_Lavatrice_Altri);
    }
    public void lavoro_auto() {
        audioSource.PlayOneShot(TTS_Lavoro_Auto);
    }
    public void lavoro_bici() {
        audioSource.PlayOneShot(TTS_Lavoro_Bici);
    }
    public void lavoro_mezzi_amici() {
        audioSource.PlayOneShot(TTS_Lavoro_Mezzi_Amici);
    }
    public void luci_accese() {
        audioSource.PlayOneShot(TTS_Luci_Accese);
    }
    public void luci_spengo() {
        audioSource.PlayOneShot(TTS_Luci_Spengo);
    }
    public void roomba_acceso() {
        audioSource.PlayOneShot(TTS_Roomba_Acceso);
    }
    public void roomba_spento() {
        audioSource.PlayOneShot(TTS_Roomba_Spento);
    }
}
