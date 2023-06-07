using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text_name_manager : MonoBehaviour
{
    public int HP_value, Sanity_value;
    public TextMeshProUGUI HPtextValue, SanitytextValue, storytextValue;
    public string startofstory;
    public GameObject level1Choices;
    
    // Start is called before the first frame update
    void Start()
    {
        HP_value = 10;
        Sanity_value = 10;
        startofstory = "I woke up then back to sleep";
    }

    // Update is called once per frame
    void Update()
    {
        HPtextValue.text = HP_value.ToString();
        SanitytextValue.text = Sanity_value.ToString();
        storytextValue.text = startofstory;

    }

    public void Goupstairs()
    {
        HP_value -= 10;
        startofstory = "You went back to sleep but you went into a coma";
        level1Choices.SetActive(false);
    }
    public void Sleep()
    {
        HP_value -= 10;
        startofstory = "You went back to sleep but you went into a coma";
    }
    public void Brushteeth()
    {
        HP_value -= 10;
        startofstory = "You brush to well, you started to bleed";
    }
    public void ExitButton() 
    {
        Application.Quit();
    }
    public void StartButton()
    {
        level1Choices.SetActive(true);
        HPtextValue.SetActive(true);
        HP_value.SetActive(true);
        SanitytextValue.SetActive(true);
        Sanity_value.SetActive(true);
    }
}

