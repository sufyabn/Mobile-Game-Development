using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [Header("Item Collection Settings")]
    public int totalItems = 11;          // Number of items in this level
    private int collectedItems = 0;     // How many items have been collected

    [Header("Next Level Settings")]
    public string level = "level complete";        // The name of the next scene

    // Call this method when an item is collected
    public void CollectItem()
    {
        collectedItems++;
        Debug.Log("Collected: " + collectedItems + "/" + totalItems);

        // Check if all items are collected
        if (collectedItems >= totalItems)
        {
            LoadNextLevel();
        }
    }

    // Load the next level
    private void LoadNextLevel()
    {
        Debug.Log("All items collected! Loading next level...");
        SceneManager.LoadScene(level);
    }
}
