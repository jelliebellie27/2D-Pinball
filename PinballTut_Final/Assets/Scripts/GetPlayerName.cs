using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayerName : MonoBehaviour
{
    static InputField PlayerName;
    static Text ShowName;

    void Update()
    {

    }

    public void DisplayName()
    {
        ShowName.text = PlayerName.text;
    }

}
