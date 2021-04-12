using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomTrackableEventHandler : DefaultTrackableEventHandler
{
    // Crear variables para la imagen mostrada en unity
    public Image detectionImg;
    [Space]
    public Color colorFound;
    public Color colorLost;

    public override void OnTrackingFound(){
        base.OnTrackingFound();
        //Debug.Log($"<color=green><b> Found! </b> </color>");
        detectionImg.color = colorFound;
    }

    public override void OnTrackingLost(){
        base.OnTrackingLost();
        //Debug.Log($"<color=red><b> Lost! </b> </color>");
        detectionImg.color = colorLost;
    }
}
