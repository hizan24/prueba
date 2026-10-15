using UnityEngine;

public class MutantPet : MonoBehaviour
{
    // Atributos públicos (visibles y editables desde el Inspector de Unity)
    public string petName = "BichoRaro";

    // Atributos privados (ocultos en el Inspector, protegidos)
    private int energyLevel = 100;
    private string currentMood = "Hambriento";

    // Método público para cambiar el estado de ánimo desde otros scripts
    public void SetMood(string newMood)
    {
        currentMood = newMood;
        Debug.Log(petName + " ahora está: " + currentMood);
    }
}
