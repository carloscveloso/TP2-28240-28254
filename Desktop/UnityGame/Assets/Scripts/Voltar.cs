using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Voltar : MonoBehaviour
{
     public void ComeBack(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

}
