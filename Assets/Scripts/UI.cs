using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI HealthText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "0";
        HealthText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        var pointSys = GameObject.FindGameObjectWithTag("Player").GetComponent<PointSystem>();
        ScoreText.text = pointSys.GetPoints().ToString();

        var healthSys = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>();
        HealthText.text = healthSys.GetHealth().ToString();
    }
}
