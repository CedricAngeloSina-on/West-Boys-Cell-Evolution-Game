using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellClassChecker : MonoBehaviour
{
    public PlayerStats stats;

    [Header("Game Objects")]
    public GameObject Crenarchaeota;
    public GameObject Euryarchaeota;
    public GameObject Cyanobacteria;
    public GameObject Proteobacteria;
    public GameObject Plant;
    public GameObject Animal;
    public GameObject Fungi;
    public GameObject Protist;
    
    // [Header("")]
    
    void Update()
    {
        if (stats.currentCellClass == "Crenarchaeota Cell")
        {
            Crenarchaeota.SetActive(true);
            Destroy(Euryarchaeota);
            Destroy(Cyanobacteria);
            Destroy(Proteobacteria);
            Destroy(Plant);
            Destroy(Animal);
            Destroy(Fungi);
            Destroy(Protist);
        } else if (stats.currentCellClass == "Euryarchaeota Cell")
        {
            Euryarchaeota.SetActive(true);
            Destroy(Crenarchaeota);
            Destroy(Cyanobacteria);
            Destroy(Proteobacteria);
            Destroy(Plant);
            Destroy(Animal);
            Destroy(Fungi);
            Destroy(Protist);
        } else if (stats.currentCellClass == "Cyanobacteria Cell")
        {
            Cyanobacteria.SetActive(true);
            Destroy(Euryarchaeota);
            Destroy(Crenarchaeota);
            Destroy(Proteobacteria);
            Destroy(Plant);
            Destroy(Animal);
            Destroy(Fungi);
            Destroy(Protist);
        } else if (stats.currentCellClass == "Proteobacteria Cell")
        {
            Proteobacteria.SetActive(true);
            Destroy(Euryarchaeota);
            Destroy(Cyanobacteria);
            Destroy(Crenarchaeota);
            Destroy(Plant);
            Destroy(Animal);
            Destroy(Fungi);
            Destroy(Protist);
        } else if (stats.currentCellClass == "Plant Cell")
        {
            Plant.SetActive(true);
            Destroy(Euryarchaeota);
            Destroy(Cyanobacteria);
            Destroy(Proteobacteria);
            Destroy(Crenarchaeota);
            Destroy(Animal);
            Destroy(Fungi);
            Destroy(Protist);
        } else if (stats.currentCellClass == "Animal Cell")
        {
            Animal.SetActive(true);
            Destroy(Euryarchaeota);
            Destroy(Cyanobacteria);
            Destroy(Proteobacteria);
            Destroy(Plant);
            Destroy(Crenarchaeota);
            Destroy(Fungi);
            Destroy(Protist);
        } else if (stats.currentCellClass == "Fungi Cell")
        {
            Fungi.SetActive(true);
            Destroy(Euryarchaeota);
            Destroy(Cyanobacteria);
            Destroy(Proteobacteria);
            Destroy(Plant);
            Destroy(Animal);
            Destroy(Crenarchaeota);
            Destroy(Protist);
        } else if (stats.currentCellClass == "Protist Cell")
        {
            Protist.SetActive(true);
            Destroy(Euryarchaeota);
            Destroy(Cyanobacteria);
            Destroy(Proteobacteria);
            Destroy(Plant);
            Destroy(Animal);
            Destroy(Fungi);
            Destroy(Crenarchaeota);
        }
    }

    
}
