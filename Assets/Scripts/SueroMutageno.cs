using UnityEngine;

public class MutagenSerum : MonoBehaviour
{

    //Attributes
    //Public
    public string serumFlavor = "Platano Radioactivo";
    public MutantPet targetPet;


    //Private
    private float toxicityLevel = 45.5f;

    //Methods
    public void AplicarSuero()
    {
        if (targetPet != null)
        {
            Debug.Log("¡Aplicando suero " + serumFlavor + " a " + targetPet.petName + "!");
            targetPet.SetMood("¡Mutando con energia furiosa!");
        }
        else
        {
            Debug.LogWarning("¡No hay ninguna mascota seleccionada para este suero!");
        }
    }
}
