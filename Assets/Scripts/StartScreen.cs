using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour
{
    public TextMeshProUGUI inputName;
    public TMPro.TMP_InputField inputHoles;
    public int holeNumber;
    public Button button;

    //Checks for empty fields and convert input to int.
    private void Update()
    {
        if(inputName.text == "" || inputHoles.text == "")
        {
            button.interactable = false;
        }
        else if(inputName.text != "" && inputHoles.text != "")
        {
            button.interactable = true;
        }

        int.TryParse(inputHoles.text, out holeNumber);
    }

    //Set playerpref data so it can be used in gamemanager
    private void OnDisable()
    {
        PlayerPrefs.SetInt("holes", holeNumber);
        PlayerPrefs.SetString("name", inputName.text);
    }
}
