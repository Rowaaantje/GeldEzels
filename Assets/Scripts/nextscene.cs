using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;
public class nextscene: MonoBehaviour
{
public string scenename;

        public void scenechange () { 
        SceneManager.LoadScene (scenename);
        }
}
    
