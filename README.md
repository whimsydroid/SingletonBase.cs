# SingletonBase.cs - Singleton Base Class
A generic reusable singleton pattern for Unity managers and systems. Prevents duplicate instances and optionally keeps the object alive across scenes.



### Description
A lightweight, generic singleton pattern for Unity that ensures only one instance of a manager or system exists at a time.
Automatically handles duplicates, optional scene persistence, and lazy initialization — perfect for Game Managers, Audio Managers, and other global controllers.

---

### Features
- Generic and reusable — works for any MonoBehaviour type
- Thread-safe lazy access pattern
- Auto-creates instance if missing
- Optional “Don’t Destroy On Load” behavior
- Duplicate instances are safely destroyed

---

### Setup

1. Create a new class inheriting from SingletonBase<T>, where T is your class name:
	public class AudioManager : SingletonBase<AudioManager>
	{
	    public void PlayClick() => Debug.Log("Click Sound Played");
	}
2. Add the derived class to any GameObject in your scene.
3. Access it from anywhere using:
	AudioManager.Instance.PlayClick();
4. (Optional) Enable “Don’t Destroy On Load” in the inspector if you want it to persist across scenes.

---

### Example
	public class GameManager : SingletonBase<GameManager>
	{
	    public int CurrentScore { get; private set; }
	
	    public void AddScore(int value)
	    {
	        CurrentScore += value;
	        Debug.Log($"Score updated: {CurrentScore}");
	    }
	}

---

### Usage:
	
	GameManager.Instance.AddScore(100);
