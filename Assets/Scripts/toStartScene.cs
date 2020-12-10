using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toStartScene : MonoBehaviour
{
   public void gotoStartScene()
   {
        SceneManager.LoadScene(2);
   }
}
