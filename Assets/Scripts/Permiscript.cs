using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Permiscript : MonoBehaviour {
    public static Permiscript Instance;
    private void Awake() { if (Instance == null) { DontDestroyOnLoad(gameObject); Instance = this; } else if (Instance = this) { Destroy(gameObject); } }

    [SerializeField] public int captain;
    
    public void setCaptain(int cap) {
        captain = cap;
    }

    public int getCaptain() {
        return captain;
    }
}
