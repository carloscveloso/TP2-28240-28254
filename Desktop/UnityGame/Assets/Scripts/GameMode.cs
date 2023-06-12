using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{
    public Camera cam1, cam2;

    private void Awake(){

    }

    private void Play(){
        cam1.rect = new Rect(0, 0, 0.5f, 1);
        cam2.rect = new Rect(0.5f, 0, 0.5f, 1);
    }
}
