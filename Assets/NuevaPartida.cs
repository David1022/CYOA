﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NuevaPartida: MonoBehaviour {

    private string NUEVA_PARTIDA_SCENE = "Partida Nueva";

    public void CargarNuevaPartida() {
        SceneManager.LoadScene(NUEVA_PARTIDA_SCENE);
    }
}
