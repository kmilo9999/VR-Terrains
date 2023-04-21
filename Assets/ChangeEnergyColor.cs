using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeEnergyColor : MonoBehaviour
{

    [SerializeField] Color32 finalColor;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().color = new Color(0.5f,0.5f,0.5f,0.40f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
        GetComponent<Image>().color = finalColor;
    }
}
