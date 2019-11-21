using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Permiscript : MonoBehaviour {

    public static Permiscript Instance;
    [SerializeField] private static int captain = 0;

    private void Awake() {
        if (Instance == null) {
            DontDestroyOnLoad(gameObject); Instance = this;
        }
        else if (Instance = this) {
            Destroy(gameObject);
        }
    }

    public void setCaptain(int cap) {
        captain = cap;
    }

    public int getCaptain() {
        return captain;
    }
}
