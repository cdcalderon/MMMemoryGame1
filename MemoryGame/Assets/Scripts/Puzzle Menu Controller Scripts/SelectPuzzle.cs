using UnityEngine;
using System.Collections;

public class SelectPuzzle : MonoBehaviour
{

    [SerializeField]
    private GameObject selectPuzzleMenuPanel, puzzleLevelSelectPanel;

    [SerializeField] private Animator selectPuzzleMenuAnim, puzzleLevelSelectAnim;

    private string selectPuzzle;

    public void SelectedPuzzle()
    {
        selectPuzzle = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        StartCoroutine(ShowPuzzleLevelSelectMenu());
    }

    IEnumerator ShowPuzzleLevelSelectMenu()
    {
        puzzleLevelSelectPanel.SetActive(true);
        selectPuzzleMenuAnim.Play("SlideOut");
        puzzleLevelSelectAnim.Play("SlideIn");
        yield return new WaitForSeconds(1f);
        selectPuzzleMenuPanel.SetActive(false);
    }

}
