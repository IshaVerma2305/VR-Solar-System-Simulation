using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoTOEarthScene : MonoBehaviour
{
    public int EarthSceneIndex;
    public int OpeningSceneIndex;
    public int JupiterSceneIndex;
    public int MercurySceneIndex;
    public int VenusSceneIndex;
    

    public void LoadEarthScene()
    {
        SceneManager.LoadScene(EarthSceneIndex); // Load Solar Eclipse scene by index
    }
    public void LoadOpeningscene()
    {
        SceneManager.LoadScene(OpeningSceneIndex); // Load Solar Eclipse scene by index
    }
    public void LoadJupiterScene()
    {
        SceneManager.LoadScene(JupiterSceneIndex); // Load Solar Eclipse scene by index
    }
    public void LoadMercuryScene()
    {
        SceneManager.LoadScene(MercurySceneIndex);
    }
    public void LoadVenusScene()
    {
        SceneManager.LoadScene(VenusSceneIndex); // Load Solar Eclipse scene by index
    }
}
