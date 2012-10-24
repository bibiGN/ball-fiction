using UnityEngine;

/// <summary>
/// Script gérant l'affichage du temps
/// </summary>
public class DisplayTimeScript : MonoBehaviour {
	// Instance de la classe
    private static DisplayTimeScript _instance;
	
	/// <summary>
	/// Propriété pour accéder publiquement à l'instance de la classe
	/// </summary>
    public static DisplayTimeScript Instance {
        get {
			// Si l'instance n'existe pas, on la crée
            if (DisplayTimeScript._instance == null) {
                DisplayTimeScript._instance = new DisplayTimeScript();
			}
            return DisplayTimeScript._instance;
        }
    }
	
	// Constructeur privé pour être sûr qu'il n'y ait qu'une seule instance
    private DisplayTimeScript() {}
	
	// Le texte pour afficher le temps
    private TextMesh _textMesh;

	void Awake () {
		// Unity créera l'objet même si le constructeur est privé donc on doit initialiser l'instance de notre singleton ici
        if (DisplayTimeScript._instance == null) {
            DisplayTimeScript._instance = this;
        } else if (DisplayTimeScript._instance != this) {
            Destroy(this.gameObject);
        }
		// On récupère le textMesh associé
        this._textMesh = this.GetComponent<TextMesh>();
        if (this._textMesh == null) {
            Destroy(this.gameObject);
		}
        this.DisplayTime();
	}
	
	public void DisplayTime() {
        if (this._textMesh != null) {
            this._textMesh.text = GameClasse.Instance.FormatedGameTime;
		}
	}

}
