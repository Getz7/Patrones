using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class TimeController : MonoBehaviour

{
    [SerializeField] int min, seg;
    [SerializeField] TextMeshProUGUI tiempo;

    private float restante;
    private bool enMarcha;
    


    private void Awake() { 
        restante = (min * 60) + seg;
        enMarcha = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (enMarcha)
        {
            restante -= Time.deltaTime;

            if(restante < 1)
            {
                enMarcha = false;
                // Matar al jugador
            }
            int tempMin = Mathf.FloorToInt(restante / 60);
            int tempSeg = Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
        }
    }
}
