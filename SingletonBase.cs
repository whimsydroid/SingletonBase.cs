/*
 * ===========================================
 *  SingletonBase.cs
 *  Author: Whimsy Droid (https://linktr.ee/whimsydroid) 
 *  Description:
 *      A generic reusable singleton pattern for Unity managers and systems.
 *      Prevents duplicate instances and optionally keeps the object alive across scenes.
 *
 *  Usage:
 *      1. Inherit from SingletonBase<T> instead of MonoBehaviour.
 *         Example:
 *             public class AudioManager : SingletonBase<AudioManager>
 *             {
 *                 // Your audio logic here
 *             }
 *
 *      2. (Optional) Enable 'dontDestroyOnLoad' in the inspector to persist across scenes.
 *
 *  Notes:
 *      - Automatically creates an instance if none exists (optional).
 *      - Thread-safe initialization with lazy access.
 * ===========================================
 */

using UnityEngine;

namespace WhimsyDroid.Utility
{

    public abstract class SingletonBase<T> : MonoBehaviour where T : MonoBehaviour
    {

        #region Fields

        // === Inspector ===

        [Header("Singleton Settings")]
        [Tooltip("Keep this instance alive when loading new scenes.")]
        [SerializeField] bool dontDestroyOnLoad = true;

        // === Internal Use Only ===
        private static T _instance;
        private static readonly object _lock = new object();

        #endregion

        #region Startups

        /// <summary>
        /// Public access to the singleton instance.
        /// </summary>
        public static T Instance
        {
            get
            {
                // Thread-safe access
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        // Try to find existing instance
                        _instance = FindFirstObjectByType<T>();

                        if (_instance == null)
                        {
                            // Create a new instance if none found
                            GameObject singletonGO = new GameObject(typeof(T).Name + " (Singleton)");
                            _instance = singletonGO.AddComponent<T>();

                            Debug.Log($"[SingletonBase] Created new instance of {typeof(T)}");
                        }
                    }
                    return _instance;
                }
            }
        }

        /// <summary>
        /// Called when the singleton is initialized.
        /// </summary>
        protected virtual void Awake()
        {
            // Handle duplicate instances
            if (_instance == null)
            {
                _instance = this as T;

                if (dontDestroyOnLoad)
                    DontDestroyOnLoad(gameObject);
            }
            else if (_instance != this)
            {
                Debug.LogWarning($"[SingletonBase] Duplicate instance of {typeof(T)} destroyed.");
                Destroy(gameObject);
            }
        }

        #endregion

        #region Cleanups

        /// <summary>
        /// Optional manual cleanup if needed.
        /// </summary>
        protected virtual void OnDestroy()
        {
            if (_instance == this)
                _instance = null;
        }

        #endregion
    }

}