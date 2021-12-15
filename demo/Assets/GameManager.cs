using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  bool gameHasEnded = false;
  public void EndGame(){
    if (gameHasEnded == false) {
      gameHasEnded = true;
      Debug.Log("GAME OVER");
      // restart game
      Restart();
    }
  }
  void Restart() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
