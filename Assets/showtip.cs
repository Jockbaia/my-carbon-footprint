using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showtip : MonoBehaviour
{
    
    private GameObject player;
    public Text itemText;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Giocatore");
        itemText.text = "AA";
    }

    // Update is called once per frame
    void Update()
    {
        int score = player.GetComponent<PlayerData>().getScore();
        if(score == 22) itemText.text = "Complimenti! Le tue abitudini quotidiane in termini di consumo di CO2 sono davvero invidiabili, potresti benissimo essere un modello da seguire sui comportamenti che ognuno di noi dovrebbe assumere per ridurre il numero di emissioni di anidride carbonica. Continua così!";
        else if(score < 22 && score >= 20) itemText.text = "Complimenti per le tue abitudini! I tuoi comportamenti quotidiani sono consapevoli ed intelligenti... Ma ricordati che si può ancora fare di meglio!";
        else if(score <= 19 && score >= 15) itemText.text ="Ottimo! Si vede che i tuoi comportamenti quotidiani in relazione al consumo di CO2 sono consapevoli e intelligenti, tuttavia, si puo’ sempre fare qualcosina in più, ad esempio:";
        else if(score <= 14 && score >= 8) itemText.text ="Bene! C’è della consapevolezza nelle tue azioni in relazione alle emissioni di CO2, ma ci sono ancora tanti piccoli sforzi nelle tue abitudini quotidiane a cui puoi prestare attenzione, ad esempio:";
        else if(score <= 7 && score >= 1) itemText.text ="Non ci siamo! Dovresti rivedere le tue abitudini quotidiane! Basta veramente poco per migliorare i propri comportamenti in relazioni al consumo individuale di CO2, fai attenzione ai suggerimenti che sto per darti:";
        else if(score <= 0) itemText.text ="Non ci siamo proprio! Le tue abitudini quotidiane in relazione al consumo individuale di CO2  dovrebbero essere riviste completamente! Ma io ho fiducia in te, prendi nota di ciò ti sto per dire:";
    }
}
