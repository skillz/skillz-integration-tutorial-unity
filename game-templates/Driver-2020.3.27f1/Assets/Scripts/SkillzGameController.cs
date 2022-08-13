/*using SkillzSDK;
using UnityEngine.SceneManagement;

public sealed class SkillzGameController : SkillzMatchDelegate
{
    private const string GameScene            = Car.Scene;  // Your game scene name
    private const string ProgressionRoomScene = Progression.Scene; // Your player progression room
    private const string StartMenuScene       = MainMenu.Scene;  // Your menu scene exiting Skillz will return to (optional)

    // Called when a player chooses a tournament and the match countdown expires
    public void OnMatchWillBegin(Match matchInfo) {
        // Uncomment to launch your game from the Skillz UI
        //SceneManager.LoadScene(GameScene);
    }

    // Called when a player clicks the Progression entry point or side menu. Explained in later steps
    public void OnProgressionRoomEnter() {
        // Uncomment to enable the Skillz Progression scene
        //SceneManager.LoadScene(ProgressionRoomScene);
    }

    // Called when a player chooses Exit Skillz from the side menu
    public void OnSkillzWillExit() {
        // Uncomment to allow players to Exit the Skillz UI
        //SceneManager.LoadScene(StartMenuScene);
    }
}*/