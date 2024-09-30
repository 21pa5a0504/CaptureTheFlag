using UnityEngine.UI;

class ThemeDecider {
  public static void Main(String[] args) {
    GameObject dayTheme;
    GameObject nightTheme;

    private void Start() {

      dayTheme.SetActive(false);
      nightTheme.SetActive(false);
      
      if(ThemeSelection.optedTheme == 1) {
        dayTheme.SetActive(true);
        nightTheme.SetActive(false);
      }
      else if(ThemeSelection.optedTheme == 2) {
        nightTheme.SetActive(true);
        dayTheme.SetActive(false);
      }
  }
}
