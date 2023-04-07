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
    private void OnDisable()
    {
        PlayerPrefs.SetInt("holes", holeNumber);
        PlayerPrefs.SetString("name", inputName.text);
    }
}
