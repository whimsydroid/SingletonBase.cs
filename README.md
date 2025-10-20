# 🌈 SingletonBase.cs — A Reusable Singleton Pattern for Unity  
### Made with whimsy by [Whimsy Droid](https://linktr.ee/whimsydroid) 🤖💫  


A lightweight, generic Singleton pattern for Unity that ensures only one instance of a manager or system exists at a time.  
It automatically handles duplicates, optional scene persistence, and lazy initialization — perfect for Game Managers, Audio Managers, and other global controllers.

---

## ✨ Features
- 🧩 **Generic & Reusable** — works for any `MonoBehaviour` type  
- ⚙️ **Thread-Safe Lazy Access** pattern  
- 🎮 **Auto-Creates Instance** if missing  
- 💾 **Optional “Don’t Destroy On Load”** behavior  
- 🧼 **Safely Destroys Duplicates**  

---

## 🧰 Setup

1. **Create a new class** inheriting from `SingletonBase<T>`:
   ```csharp
   public class AudioManager : SingletonBase<AudioManager>
   {
       public void PlayClick() => Debug.Log("Click Sound Played");
   }
2. Add the derived class to any GameObject in your scene.
3. Access it from anywhere using:
   ```csharp
   AudioManager.Instance.PlayClick();



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
