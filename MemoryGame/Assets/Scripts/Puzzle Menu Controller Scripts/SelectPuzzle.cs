using UnityEngine;
using System.Collections;

public class SelectPuzzle : MonoBehaviour
{

    [SerializeField]
    private GameObject selectPuzzleMenuPanel;

    [SerializeField] private Animation selectPuzzleMenuAnim;

    private string selectPuzzle;

    public void SelectedPuzzle()
    {
        selectPuzzle = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(selectPuzzle);
    }

}
