# 🌈 SingletonBase.cs — A Reusable Singleton Pattern for Unity  
### Made with whimsy by [Whimsy Droid](https://linktr.ee/whimsydroid) 🤖💫  

### Description
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
4. (Optional) Enable “Don’t Destroy On Load” in the inspector to persist across scenes.

---

### Example
   ```csharp
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

---

💾 Download & Explore

- 🐙 GitHub Repository:[Whimsy Droid](https://github.com/whimsydroid)
- [Payhip](https://payhip.com/whimsydroid)
- [Gumroad](https://whimsydroid.gumroad.com/)
- 🚀 Support Development:
	• [Ko-fi](https://ko-fi.com/whimsydroid)
  	• [Patreon](https://patreon.com/whimsydroid)
 	• [GitHub Sponsors](https://github.com/sponsors/whimsydroid)


🎥 Follow Whimsy Droid
	  Stay connected for updates, new free tools, and video tutorials!
- 📺 [YouTube](https://www.youtube.com/@whimsydroid)
- 📘 [Facebook](https://www.facebook.com/whimsydroid)
- 📸 [Instagram](https://www.instagram.com/whimsydroid)
- 🎵 [TikTok](https://www.tiktok.com/@whimsydroid)
- 🐦 [X (Twitter)](https://x.com/whimsydroid)

	

