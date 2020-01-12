using UnityEngine;
using System.Collections;
using TMPro;

public class coin1 : MonoBehaviour
{
    void Example()
    {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.SetText("Coins : ", gm.coins);

    }
}