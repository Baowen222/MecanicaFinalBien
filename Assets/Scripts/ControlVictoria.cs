using UnityEngine;

public class ControlVictoria : MonoBehaviour
{
    public bool paredRota;
    public bool botonActivado;
    public bool puertaAbierta;
    public bool jugadorEnMeta;
    public bool juegoGanado;

    public GameObject panelVictoria;
    public TextMesh textoAviso;
    public float tiempoAviso = 2f;

    private float tiempoRestanteAviso;

    void Start()
    {
        juegoGanado = false;

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
        ControlarAviso();
    }

    void ControlarAviso()
    {
        if (textoAviso == null)
        {
            return;
        }

        if (textoAviso.gameObject.activeSelf)
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
        else
        {
            MostrarFaltanPruebas();
        }
    }

    public void MostrarFaltanPruebas()
    {
        Debug.Log("Primero completa todas las pruebas");

        if (textoAviso != null)
        {
            textoAviso.text = "Primero completa todas las pruebas";
            textoAviso.gameObject.SetActive(true);
            tiempoRestanteAviso = tiempoAviso;
        }
    }
}