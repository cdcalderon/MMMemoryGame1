﻿using UnityEngine;
using System.Collections;

public class SelectLevel : MonoBehaviour
{
    [SerializeField]
    private PuzzleGameManager puzzleGameManager;

    [SerializeField]
    private LoadPuzzleGame loadPuzzleGame;

    [SerializeField]
    private GameObject selectPuzzleMenuPanel, puzzleLevelSelectPanel;

    [SerializeField]
    private Animator selectPuzzleMenuAnim, puzzleLevelSelectAnim;

    private string selectedPuzzle;

    public void BackToPuzzleSelectMenu()
    {
        StartCoroutine (ShowPuzzleSelectMenu());
    }

    public void SelectPuzzleSelectLevel()
    {
        int level = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        puzzleGameManager.SetLevel(level);

        loadPuzzleGame.LoadPuzzle(level, selectedPuzzle);
    }
    IEnumerator ShowPuzzleSelectMenu()
    {
        selectPuzzleMenuPanel.SetActive(true);
        selectPuzzleMenuAnim.Play("SlideIn");
        puzzleLevelSelectAnim.Play("SlideOut");
        yield return new WaitForSeconds(1f);
        puzzleLevelSelectPanel.SetActive(false);
    }

    public void SetSelectedPuzzle(string selectedPuzzle)
    {
        this.selectedPuzzle = selectedPuzzle;
        Debug.Log("The selected puzzle is " + selectedPuzzle);
    }
}
