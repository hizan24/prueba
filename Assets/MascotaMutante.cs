using UnityEngine;

public class MascotaMutante : MonoBehaviour
{
    //Attributes
    //Public
    public string petName = "BichoRaro";
    
        
    //Private
    private int energyLevel = 100;
    private string currentMood = "Hambriento";

    //Methods

    public void SetMood(string newMood)
    {
        currentMood = newMood;
       Debug.Log(petName + " ahora esta " + currentMood);
    }

}
