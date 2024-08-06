using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    private int score = 0;
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        GameManager.OnCubeSpawned += GameManager_OnCubeSpawned;
    }
    private void OnDestroy()
    {
        GameManager.OnCubeSpawned -= GameManager_OnCubeSpawned;
    }
    private void GameManager_OnCubeSpawned()
    {
        score++;
        text.text = "Score: " + score;
    }

}
