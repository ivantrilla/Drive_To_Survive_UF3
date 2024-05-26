using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public GameObject motorCarreterasGO;
    public MotorCarreteras MotorCarreteras;

    public float tiempo;
    public float distancia;
    public Text txtTiempo;
    public Text txtDistancia;
    public Text txtDistanciaFinal;

    void Start()
    {
        motorCarreterasGO = GameObject.Find("MotorCarreteras");
        MotorCarreteras = motorCarreterasGO.GetComponent<MotorCarreteras>();

        txtTiempo.text = "1:00";
        txtDistancia.text = "0";

        tiempo = 60;
    }

    void Update()
    {
        if (MotorCarreteras.inicioJuego == true && MotorCarreteras.juegoTerminado == false)
        {
            TiempoDistancia();
        }

        if (tiempo <= 0.99f && MotorCarreteras.juegoTerminado == false)
        {
            Finish();
        }
    }

    void TiempoDistancia()
    {
        distancia += Time.deltaTime * MotorCarreteras.velocidad;
        txtDistancia.text = ((int)distancia).ToString();

        tiempo -= Time.deltaTime;
        int minutos = (int)tiempo / 60;
        int segundos = (int)tiempo % 60;
        txtTiempo.text = minutos.ToString() + ":" + segundos.ToString().PadLeft(2, '0');
    }

    public void Finish()
    {
        MotorCarreteras.juegoTerminado = true;
        MotorCarreteras.JuegoTerminado((int)distancia);

        txtDistanciaFinal.text = ((int)distancia).ToString() + " meters";
        txtTiempo.text = "0:00";
        Time.timeScale = 0f;
    }

    public void RestartVelocity()
    {
        MotorCarreteras.velocidad = 6;
    }
}
