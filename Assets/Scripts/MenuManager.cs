using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
   public void ChangeSceneByName(string name) {
       SceneManager.LoadScene(name);
   }
}
