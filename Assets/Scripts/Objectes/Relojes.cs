using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relojes : MonoBehaviour
{
    public GameObject CronometroGO;
    public Cronometro CronometroScript;

    public GameObject AnalyticsGO;

    void Start()
    {
        CronometroGO = GameObject.FindObjectOfType<Cronometro>().gameObject;
        CronometroScript = CronometroGO.GetComponent<Cronometro>();
        AnalyticsGO = GameObject.Find("GameMasterAnalytics");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Coche>() != null)
        {
            AnalyticsGO.GetComponent<GameMasterAnalytics>().relojes++;
            CronometroScript.tiempo = CronometroScript.tiempo + 10;
            Destroy(this.gameObject);
        }
    }
}
