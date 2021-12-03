using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LowLight;
    public GameObject MediumLight;
    public GameObject HighLight;
    void Start()
    {
        LowLight.SetActive(false);
        MediumLight.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
