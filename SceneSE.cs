using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int solarEclipseSceneIndex; // Index of the Solar Eclipse scene in the build settings
    public int sampleSceneIndex; // Index of the Sample scene in the build settings
    public int OpeningSceneIndex;

    public int LunarEclipseSceneIndex;

    public int JupiterSceneIndex;

    public int VenusSceneIndex;
    public void LoadSolarEclipseScene()
    {
        SceneManager.LoadScene(solarEclipseSceneIndex); // Load Solar Eclipse scene by index
    }

    public void LoadSampleScene()
    {
        SceneManager.LoadScene(sampleSceneIndex); // Load Sample scene by index
    }
    public void LoadOpeningscene()
    {
        SceneManager.LoadScene(OpeningSceneIndex);
    }

    public void LoadLunarEclipseScene()
    {
        SceneManager.LoadScene(LunarEclipseSceneIndex); // Load Solar Eclipse scene by index
    }

    public void LoadJupiterScene()
    {
        SceneManager.LoadScene(JupiterSceneIndex);
    }
    public void LoadVenusScene()
    {
        SceneManager.LoadScene(VenusSceneIndex);
    }
}
