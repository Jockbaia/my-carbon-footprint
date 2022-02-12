using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showTipContext : MonoBehaviour
{
    private int[] badFlags = new int[9];
    private string[] tip = new string[9];

    public Text itemText;



    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<9; i++) {
            badFlags[i] = 0;
        }
        
        tip[0] = "Attenzione al consumo di plastica! Una piccola azione come usare una borraccia da riempire, o solo riutilizzare la stessa bottiglietta d’acqua può essere un piccolo passo per un consumo più consapevole.";
        tip[1] = "Per i grandi spostamenti il treno rimane il mezzo meno impattante! Se ti capita di trovare dei prezzi uguali o inferiori di un biglietto del treno rispetto alle altre alternative, cerca di optare per questa scelta!";
        tip[2] = "Si sa che il sapore del caffè con la macchinetta è tutto un’altra cosa, ma farlo quotidianamente comporta un consumo individuale di CO2 veramente notevole! Cerca di consumarne il meno possibile.";
        tip[3] = "Piccoli accorgimenti nell’alimentazione non solo hanno un impatto positivo dal punto di vista ecologico, ma anche rispetto alla tua salute! Cerca di consumare meno carne e meno prodotti industriali, prediligendo prodotti del territorio o di allevamenti controllati.";
        tip[4] = "I biscotti sono buoni, ma ricorda che la manifattura industriale incide sull'ambiente molto di più di un prodotto realizzato in un panificio locale!";
        tip[5] = "Cerca di utilizzare delle temperature di lavaggio più alte di 30 °C solo se i capi sono veramente sporchi, molto spesso non è necessario lavare ad alte temperature.";
        tip[6] = "Fare una lunga doccia calda è piacevole, si sa, ma fatta quotidianamente ha un impatto ecologico davvero troppo alto. Qualche volta puoi testare i benefici corporei di una doccia fredda!";
        tip[7] = "Riscopri il piacere di utilizzare la bicicletta per gli spostamenti, magari quando c’è bel tempo e non sei di fretta, il pianeta ti ringrazierà.";
        tip[8] = "";

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void setBadFlag(int current) {
        badFlags[current] = 1; 
    }

    public void setFinalHint() {
        
        string finalHint = "";

        for(int i=0; i<9; i++) {
            if(badFlags[i] == 1) {
                finalHint = finalHint + "\n\n" + tip[i];
            }
        }

        itemText.text = finalHint;
    }

}
