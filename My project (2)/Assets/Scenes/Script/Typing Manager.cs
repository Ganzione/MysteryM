using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TypingManager : MonoBehaviour
{
    public static TypingManager instance;

    [Header("Times for each Character")]
    public float timeForCharacter;

    [Header("Times for each Character when speed up")]
    public float timeForCharacter_Fast;

    float characterTime;

    string[] dialogSave;
    TextMeshProUGUI tmpSave;

    public static bool isDialogEnd;

    bool isTypingEnd = false;
    int dialogNumber = 0;

    float timer;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        timer = timeForCharacter;
        characterTime = timeForCharacter;
    }
}
