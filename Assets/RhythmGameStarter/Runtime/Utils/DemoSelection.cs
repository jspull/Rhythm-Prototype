using UnityEngine;
using UnityEngine.SceneManagement;

namespace RhythmGameStarter
{
    public class DemoSelection : MonoBehaviour {

        public GameObject button;

        private void Update() {
            Scene scene = SceneManager.GetActiveScene();
            button.SetActive(scene.name != "Demo Selection");
        }
        
    }
}