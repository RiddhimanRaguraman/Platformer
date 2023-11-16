using Platformer.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Marks a trigger as a VictoryZone, usually used to end the current game level.
    /// </summary>
    public class VictoryZone : MonoBehaviour
    {
        public string nextLevelName;
        void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
            {
                var ev = Schedule<PlayerEnteredVictoryZone>();
                ev.victoryZone = this;
                StartCoroutine(LoadNextLevelAfterDelay());
            }
        }
        private IEnumerator LoadNextLevelAfterDelay()
    {
        // Wait for 7 seconds
        yield return new WaitForSeconds(3f);

        // Load the next level
        SceneManager.LoadScene(nextLevelName);
    }

    }
}