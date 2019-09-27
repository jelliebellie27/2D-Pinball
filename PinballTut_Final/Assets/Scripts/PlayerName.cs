using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public InputField NameField;
    static public string playerName;

    private void Start()
    {
        playerName = "Player Name";
    }

    public void UpdateName()
    {
        playerName = NameField.text;
    }
}
