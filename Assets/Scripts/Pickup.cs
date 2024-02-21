using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Pickup : MonoBehaviour
{

    public TMP_Text ScoreValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreValue.SetText(ScoreValue + 5);
    }
}
