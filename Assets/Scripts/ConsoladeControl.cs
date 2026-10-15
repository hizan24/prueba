using UnityEngine;

public class LabConsole : MonoBehaviour
{
    // Atributos públicos
    public int maxDailyFusions = 3;

    // Referencia al suero cargado en la consola
    public MutagenSerum loadedSerum;

    // Atributos privados
    private bool alarmActive = false;

    // Método para accionar la palanca de experimentos
    public void PulsarPalancaDeFusion()
    {
        if (alarmActive)
        {
            Debug.LogError("¡ALERTA ROJA! La consola está bloqueada.");
            return;
        }

        if (loadedSerum != null)
        {
            Debug.Log("Consola iniciando proceso... FUSIÓN EN PROCESO.");
            loadedSerum.AplicarSuero();
            maxDailyFusions--;
        }
        else
        {
            Debug.LogWarning("La ranura del suero está vacía. Coloca un suero primero.");
        }
    }
}