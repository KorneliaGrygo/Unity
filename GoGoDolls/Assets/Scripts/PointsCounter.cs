using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsCounter : MonoBehaviour
{
    public TextMeshProUGUI score;
    public static int coins;
    void Awake()
    {
        score = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        score.text = coins.ToString();
    }
}
