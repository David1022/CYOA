using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverInicio : MonoBehaviour {

    private string VOLVER_A_INICIO = "Pantalla inicial";

    public void VolverAInicio() {
        SceneManager.LoadScene(VOLVER_A_INICIO);
    }
}
