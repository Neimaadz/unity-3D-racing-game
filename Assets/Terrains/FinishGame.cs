using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    [SerializeField] private GameObject car;
    
    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log(message: "C'est Gagnéé !!!!!!");
        SceneManager.LoadScene("MenuPrincipal");

    }
}
