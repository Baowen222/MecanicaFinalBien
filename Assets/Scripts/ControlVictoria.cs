using UnityEngine;
using TMPro;

public class ControlVictoria : MonoBehaviour
{
    public bool paredRota;
    public bool botonActivado;
    public bool puertaAbierta;
    public bool jugadorEnMeta;
    public bool juegoGanado;

    public GameObject panelVictoria;
    public TextMeshProUGUI textoAviso;
    public float tiempoAviso = 2f;

    float tiempoRestanteAviso;

    void Start()
    {
        if (panelVictoria != null)
        {
            panelVictoria.SetActive(false);
        }

        if (textoAviso != null)
        {
            textoAviso.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (textoAviso != null && textoAviso.gameObject.activeSelf)
        {
            tiempoRestanteAviso -= Time.deltaTime;

            if (tiempoRestanteAviso <= 0f)
            {
                textoAviso.gameObject.SetActive(false);
            }
        }
    }

    public void ComprobarVictoria()
    {
        if (juegoGanado)
        {
            return;
        }

        if (paredRota && botonActivado && puertaAbierta && jugadorEnMeta)
        {
            juegoGanado = true;

            if (panelVictoria != null)
            {
                panelVictoria.SetActive(true);
            }

            Debug.Log("Has ganado");
        }
    }

    public void MostrarFaltanPruebas()
    {
        Debug.Log("Completa las pruebas");

        if (textoAviso != null)
        {
            textoAviso.text = "Haz las pruebas;
            textoAviso.gameObject.SetActive(true);
            tiempoRestanteAviso = tiempoAviso;
        }
    }
}