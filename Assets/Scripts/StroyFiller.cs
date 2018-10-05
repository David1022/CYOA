using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StroyFiller : MonoBehaviour {

    public static GameplayManager.StoryNode FillStory() {
        GameplayManager.StoryNode root = 
            CreateNode("Te encuentras en una habitación y no recuerdas nada. Quieres salir",
                       new string[] {"Explorar objetos", "Explorar la habitación"});

        GameplayManager.StoryNode nodo1 =
            CreateNode("Hay una silla y una mesa con una planta a la izquierda. A la derecha hay una estantería con libros." +
                       "Detrás parece que hay cajas", 
                       new string[] { "Ir a la derecha", "Ir a la izquierda", "Ir hacia atrás", "Explorar la habitación"});
        root.nextNode[0] = nodo1;

        GameplayManager.StoryNode nodo2 =
            CreateNode("Nada interesante...aunque hay un libro que llama la atención...botánica para astronautas?", 
                       new string[] { "Explorar el resto de objetos de la habitación", "Averiguar más del libro raro"});
        nodo1.nextNode[0] = nodo2;
        nodo2.nextNode[0] = nodo1;

        return root;
    }

    private static GameplayManager.StoryNode CreateNode(string history, string[] options)
    {
        GameplayManager.StoryNode node = new GameplayManager.StoryNode();
        node.history = history;
        node.answers = options;
        node.nextNode = new GameplayManager.StoryNode[options.Length];
        return node;
    }
}
