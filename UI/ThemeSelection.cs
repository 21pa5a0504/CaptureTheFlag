using UnityEngine.SceneManagement;

class ThemeSelection {
  public static void Main(String[] args) {
    static int optedTheme = 0;

    public void SelectDayTheme() {
      optedTheme = 1;
      SceneManager.Load_Scene("GameScreen");
    }

    public void SelectNightTheme() {
      optedTheme = 2;
      SceneManager.Load_Scene("GameScreen");
    }
  }
}
