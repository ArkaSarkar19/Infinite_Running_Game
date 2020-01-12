using UnityEngine;
using System.Collections;
using TMPro;

public class score1 : MonoBehaviour
{
    void Example()
    {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.SetText("Score : ", (int)(gm.time * 5 + gm.coins * 3));
        
    }
}