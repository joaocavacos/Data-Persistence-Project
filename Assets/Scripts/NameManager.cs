using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class NameManager : MonoBehaviour
{
    public void LoadName(TMP_InputField input)
    {
        StateController.PlayerName = input.text;
        SceneManager.LoadScene("main");
    }
}
